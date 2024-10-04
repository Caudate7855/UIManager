using System;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;


namespace UI
{
    public abstract class UIControllerBase<TView> where TView : UIViewBase
    {
        protected TView View;

        private bool _isViewLoaded;
        private MainCanvas _mainCanvas;
        
        protected UIControllerBase()
        {
#if EXTENJECT 
#if ADDRESSABLES
            LoadFromAddressables();
#endif
#else
            LoadFromResources();
#endif
        }

        private async void LoadFromAddressables()
        {
            View = await UIViewFactory.LoadFromAddressablesAsync<TView>(_mainCanvas, GetViewAssetAddress());
            
            View.gameObject.SetActive(false);
            _isViewLoaded = true;

            Initialize();
        }

        private async void LoadFromResources()
        {
            View = await UIViewFactory.LoadFromResources<TView>(_mainCanvas, GetViewAssetAddress());
            
            View.gameObject.SetActive(false);
            _isViewLoaded = true;

            Initialize();
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

        private async Task WaitForViewToLoad()
        {
            while (!_isViewLoaded)
            {
                await Task.Yield();
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