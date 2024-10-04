using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AssetLoader
{
    public async Task<T> Load<T>(string path)
    {
        var handle = await Addressables.LoadAssetAsync<GameObject>(path);
        var result = handle.GetComponent<T>();
            
        return result;
    }
}