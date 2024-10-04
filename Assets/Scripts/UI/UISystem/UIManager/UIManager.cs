using Zenject;

namespace UI
{
    public class UIManager : IUIManager
    {
        private readonly DiContainer _container;

        public UIManager(DiContainer container)
        {
            _container = container;
        }

        public T Load<T>()
        {
            var controller = _container.Instantiate<T>();
            return controller;
        }
    }
}