namespace UI.UISystem
{
    [AssetAddress("TestWindow")]
    public class TestWindowController : UIControllerBase<TestWindowView>
    {
        public TestWindowController(IAssetLoader assetLoader) : base(assetLoader) { }

        protected override void Initialize()
        {
            
        }
    }
}