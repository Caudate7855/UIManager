using Cysharp.Threading.Tasks;

namespace UI
{
    public interface IUIManager
    {
        public T Load<T>();
    }
}