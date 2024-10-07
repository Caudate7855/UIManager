#if EXTENJECT

using Zenject;

namespace UIManager.Samples.Extenject_Addressables.Scripts
{
    public class UIManagerExampleInstaller : MonoInstaller<UIManagerExampleInstaller>
    {
        public override void InstallBindings()
        {
            InstallUIManager();
            InstallUIDependency();
            InstallControllers();
        }

        private void InstallUIDependency()
        {
            Container
                .Bind<ExampleDependency>()
                .AsSingle();
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