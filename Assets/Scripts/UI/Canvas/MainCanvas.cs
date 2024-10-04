using UnityEngine;

namespace UI
{
    public class MainCanvas : CustomCanvasBase
    {
        [SerializeField] private Vector2 _canvasSize;
        
        private Canvas _canvas;
        private RectTransform _canvasRectTransform;

        public void Awake()
        {
            DontDestroyOnLoad(this);
            
            _canvas = GetComponent<Canvas>();
            _canvasRectTransform = _canvas.GetComponent<RectTransform>();
            
            _canvasRectTransform.sizeDelta = _canvasSize;
        }
    }
}