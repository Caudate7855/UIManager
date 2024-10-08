#if EXTENJECT

using JetBrains.Annotations;
using TMPro;
using UIManager.Samples.Common;
using UnityEngine.UI;

namespace UIManager.Samples.Extenject_Addressables.Scripts
{
    [AssetAddress("ExampleWindow"), UsedImplicitly]
    public class ExampleWindowController : UIControllerBase<ExampleWindowView>
    {
        private TMP_Text _viewText;
        private Image _viewBackgroundImage;

        private ExampleDependency _exampleDependency;
        private int _exampleNumber;

        public ExampleWindowController(ExampleDependency exampleDependency)
        {
            _exampleDependency = exampleDependency;
            _exampleNumber = _exampleDependency.Number;
        }
        
        protected override void Initialize()
        {
            _viewText = View.Text;
            _viewBackgroundImage = View.BackgroundImage;
        }
    }
}

#endif