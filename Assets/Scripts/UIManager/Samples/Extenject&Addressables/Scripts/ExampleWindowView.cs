using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIManager.Samples.Extenject_Addressables.Scripts
{
    public class ExampleWindowView : UIViewBase
    {
        public TMP_Text Text => _text;
        public Image BackgroundSprite => _backgroundSprite;
        
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Image _backgroundSprite;
    }
}