using System;

namespace UI
{
    public class UIManager : IUIManager
    {
#if EXTENJECT        
        private readonly Zenject.DiContainer _container;
        public UIManager(Zenject.DiContainer container)
        {
            _container = container;
        }
#else
        public UIManager()
        {
            
        }
#endif
        public T LoadController<T>()
        {
#if EXTENJECT
            var controller = _container.Instantiate<T>();
            return controller;
#else  
            var controller = Activator.CreateInstance<T>();
            return controller;
#endif
        }
    }
}