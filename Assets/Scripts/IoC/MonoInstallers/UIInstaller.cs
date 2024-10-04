using UI;
using UI.UISystem;
using UnityEngine;
using Zenject;

public class UIInstaller : MonoInstaller<UIInstaller>
{
    [SerializeField] private MainCanvas _mainCanvas;
    
    public override void InstallBindings()
    {
        Container
            .Bind<IUIManager>()
            .To<UIManager>()
            .AsSingle();
        
        BindCanvases();
        BindControllers();
    }

    private void BindCanvases()
    {
        Container
            .Bind<MainCanvas>()
            .FromInstance(_mainCanvas)
            .AsSingle();
    }

    private void BindControllers()
    {
        Container
            .Bind<TestWindowController>()
            .AsSingle();
    }
}