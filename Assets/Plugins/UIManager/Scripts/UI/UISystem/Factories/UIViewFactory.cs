using JetBrains.Annotations;
using UnityEngine;

namespace UIManager
{
    [UsedImplicitly]
    public static class UIViewFactory
    {
#if ADDRESSABLES
        public static async System.Threading.Tasks.Task<T> LoadFromAddressablesAsync<T>(CustomCanvasBase parentCanvas, string assetPath) where T : UIViewBase
        {
            var assetLoader = new AssetLoader();
            
            var instance = await assetLoader.Load<T>(assetPath);

            instance = instance.GetComponent<T>();
            
            parentCanvas = Object.FindObjectOfType<CustomCanvasBase>();

            var viewInstance = Object.Instantiate(instance, parentCanvas.transform);
            
            return viewInstance;
        }
#endif
        public static T LoadFromResources<T>(UIManagerCanvasBase parentCanvas, string assetPath)
            where T : UIViewBase
        {
            var resourceRequest = Resources.LoadAsync<T>(assetPath);

            T viewInstance;

            if (parentCanvas != null)
            {
                viewInstance = Object.Instantiate(resourceRequest.asset, parentCanvas.transform) as T;
            }
            else
            {
                parentCanvas = Object.FindObjectOfType<UIManagerCanvasBase>();
                viewInstance = Object.Instantiate(resourceRequest.asset, parentCanvas.transform) as T;
            }

            return viewInstance;
        }
    }
}