using JetBrains.Annotations;

namespace UIManager
{
    [UsedImplicitly]
    public class UIManager : IUIManager
    {
#if EXTENJECT        
        private readonly Zenject.DiContainer _container;
        public UIManager(Zenject.DiContainer container)
        {
            _container = container;
        }
#endif
        public T LoadController<T>()
        {
#if EXTENJECT
            var controller = _container.Instantiate<T>();
            return controller;
#else  
            var controller = System.Activator.CreateInstance<T>();
            return controller;
#endif
        }
    }
}