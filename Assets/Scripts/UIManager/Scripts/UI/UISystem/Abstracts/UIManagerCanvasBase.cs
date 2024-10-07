using UnityEngine;

namespace UIManager
{
    [RequireComponent(typeof(Canvas))]
    public class UIManagerCanvasBase : MonoBehaviour
    {
        public void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}