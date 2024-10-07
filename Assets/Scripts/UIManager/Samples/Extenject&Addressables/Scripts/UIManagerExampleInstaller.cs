#if EXTENJECT

using Zenject;

namespace UIManager.Samples.Extenject_Addressables.Scripts
{
    public class UIManagerExampleInstaller : MonoInstaller<UIManagerExampleInstaller>
    {
        public override void InstallBindings()
        {
            InstallUIManager();

            Container
                .Bind<ExampleDependency>()
                .AsSingle();

            InstallControllers();
        }

        private void InstallUIManager()
        {
            Container
                .Bind<IUIManager>()
                .To<UIManager>()
                .AsSingle();
        }
        
        private void InstallControllers()
        {
            Container
                .Bind<ExampleWindowController>()
                .AsSingle();
        }
    }
}

#endif