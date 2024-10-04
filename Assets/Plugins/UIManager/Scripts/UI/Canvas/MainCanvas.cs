using UnityEngine;

namespace UIManager
{
    public class MainCanvas : UIManagerCanvasBase
    {
        public void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}