using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIManager.Samples.Common
{
    public class ExampleWindowView : UIViewBase
    {
        public TMP_Text Text => _text;
        public Image BackgroundImage => _backgroundImage;
        
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Image _backgroundImage;
    }
}