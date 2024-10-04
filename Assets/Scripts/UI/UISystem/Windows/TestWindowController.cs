using JetBrains.Annotations;

namespace UI.UISystem
{
    [AssetAddress("TestWindow"), UsedImplicitly]
    public class TestWindowController : UIControllerBase<TestWindowView>
    {
        public TestWindowController(IAssetLoader assetLoader) : base(assetLoader) { }

        protected override void Initialize()
        {
            
        }
    }
}