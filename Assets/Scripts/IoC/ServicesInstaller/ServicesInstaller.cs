using Zenject;

public class ServicesInstaller : MonoInstaller<ServicesInstaller>
{
    public override void InstallBindings()
    {
        Container
            .Bind<ISceneLoader>()
            .To<SceneLoader>()
            .AsSingle();

        Container
            .Bind<IAssetLoader>()
            .To<AssetLoader>()
            .AsSingle();
    }
}