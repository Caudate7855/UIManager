using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;

namespace UI
{
    [UsedImplicitly]
    public class UIViewFactory
    {
        public static async UniTask<T> LoadAsync<T>(IAssetLoader assetLoader, CustomCanvasBase parentCanvas, string assetPath) where T : UIViewBase
        {
            var loadedView = await assetLoader.Load<T>(assetPath);
            parentCanvas = Object.FindObjectOfType<CustomCanvasBase>();

            var viewInstance = Object.Instantiate(loadedView, parentCanvas.transform);
            return viewInstance.GetComponent<T>();
        }
    }
}