using Zenject;

public class ServicesInstaller : MonoInstaller<ServicesInstaller>
{
    public override void InstallBindings()
    {
        Container
            .Bind<IAssetLoader>()
            .To<AssetLoader>()
            .AsSingle();
    }
}