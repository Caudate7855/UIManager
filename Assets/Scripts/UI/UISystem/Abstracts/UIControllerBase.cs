using System;
using System.Linq;
using Cysharp.Threading.Tasks;

namespace UI
{
    public abstract class UIControllerBase<TView> where TView : UIViewBase
    {
        protected TView View;

        private bool _isViewLoaded;
        private MainCanvas _mainCanvas;

        private readonly IAssetLoader _assetLoader;

        protected UIControllerBase(IAssetLoader assetLoader)
        {
            _assetLoader = assetLoader;
            LoadView();
        }

        public async void Open()
        {
            if (!_isViewLoaded)
            {
                await WaitForViewToLoad();
            }

            View.gameObject.SetActive(true);
            OnOpen();
        }

        public async void Close()
        {
            if (!_isViewLoaded)
            {
                await WaitForViewToLoad();
            }

            View.gameObject.SetActive(false);
            OnClose();
        }

        protected abstract void Initialize();

        protected virtual void OnOpen() { }

        protected virtual void OnClose() { }


        private async UniTask LoadView()
        {
            View = await UIViewFactory.LoadAsync<TView>(_assetLoader, _mainCanvas, GetViewAssetAddress());

            View.gameObject.SetActive(false);
            _isViewLoaded = true;

            Initialize();
        }

        private async UniTask WaitForViewToLoad()
        {
            while (!_isViewLoaded)
            {
                await UniTask.Yield();
            }
        }

        private string GetViewAssetAddress()
        {
            var type = GetType();

            var attribute = type.GetCustomAttributes(typeof(AssetAddress), false)
                .FirstOrDefault() as AssetAddress;

            return attribute?.Address ?? throw new ArgumentException($"Cannot find Address of {type}");
        }
    }
}