using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;

[UsedImplicitly]
public class SceneLoader : ISceneLoader
{
    private Dictionary<SceneType, int> _scenes = new()
    {
        {SceneType.Boot,0},
        {SceneType.MainScene,1}
    };
    
    public void LoadScene(SceneType sceneType)
    {
        if (_scenes.TryGetValue(sceneType, out var sceneId))
        {
            if (SceneManager.GetActiveScene().buildIndex != sceneId)
            {
                SceneManager.LoadSceneAsync(sceneId);
            }
        }
    }
    
}