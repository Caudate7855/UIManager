using JetBrains.Annotations;
using TMPro;
using UIManager.Samples.Common;
using UnityEngine.UI;

namespace UIManager.Samples.NoExtenject_NoAddressables.Scripts
{
    [AssetAddress("ExampleWindowResources"), UsedImplicitly]
    public class ExampleWindowController : UIControllerBase<ExampleWindowView>
    {
        private TMP_Text _viewText;
        private Image _viewBackgroundImage;
        
        protected override void Initialize()
        {
            _viewText = View.Text;
            _viewBackgroundImage = View.BackgroundImage;
        }
    }
}