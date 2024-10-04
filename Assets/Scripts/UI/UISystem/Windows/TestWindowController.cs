using JetBrains.Annotations;

namespace UI.UISystem
{
    [AssetAddress("TestWindow"), UsedImplicitly]
    public class TestWindowController : UIControllerBase<TestWindowView>
    {
#if EXTENJECT
#if ADDRESSABLES
        public TestWindowController() : base() { }
        
#endif
#endif
        protected override void Initialize()
        {
            
        }
    }
}