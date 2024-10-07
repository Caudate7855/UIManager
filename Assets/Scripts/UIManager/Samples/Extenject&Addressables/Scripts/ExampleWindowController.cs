using JetBrains.Annotations;
using TMPro;
using UnityEngine.UI;

namespace UIManager.Samples.Extenject_Addressables.Scripts
{
    [AssetAddress("TestWindow"), UsedImplicitly]
    public class ExampleWindowController : UIControllerBase<ExampleWindowView>
    {
        private TMP_Text _text;
        private Image _backgroundSprite;

        private ExampleDependency _exampleDependency;

        public ExampleWindowController(ExampleDependency exampleDependency)
        {
            _exampleDependency = exampleDependency;
        }
        
        protected override void Initialize()
        {
            _text = View.Text;
            _backgroundSprite = View.BackgroundSprite;
        }
    }
}
