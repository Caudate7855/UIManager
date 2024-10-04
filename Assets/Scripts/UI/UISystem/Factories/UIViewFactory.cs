using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;

namespace UI
{
    [UsedImplicitly]
    public static class UIViewFactory
    {
#if EXTENJECT
#if ADDRESSABLES
        public static async Task<T> LoadFromAddressablesAsync<T>(CustomCanvasBase parentCanvas, string assetPath) where T : UIViewBase
        {
            var assetLoader = new AssetLoader();
            
            var instance = await assetLoader.Load<T>(assetPath);

            instance = instance.GetComponent<T>();
            
            parentCanvas = Object.FindObjectOfType<CustomCanvasBase>();

            var viewInstance = Object.Instantiate(instance, parentCanvas.transform);
            
            return viewInstance;
        }
#endif
#endif
        public static async Task<T> LoadFromResources<T>(CustomCanvasBase parentCanvas, string assetPath) where T : UIViewBase
        {
            var viewInstance = await Resources.LoadAsync<T>(assetPath);
            parentCanvas = Object.FindObjectOfType<CustomCanvasBase>();
            
            viewInstance = Object.Instantiate(viewInstance, parentCanvas.transform);

            return viewInstance as T;
        }
    }
}