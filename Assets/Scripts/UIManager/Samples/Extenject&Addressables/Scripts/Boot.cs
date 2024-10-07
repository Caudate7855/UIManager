#if EXTENJECT

using UnityEngine;
using Zenject;

namespace UIManager.Samples.Extenject_Addressables.Scripts
{
    public class Boot : MonoBehaviour
    {
        [Inject] private IUIManager _uiManager;
        private ExampleWindowController _exampleWindowController;

        private void Start()
        {
            _exampleWindowController = _uiManager.LoadController<ExampleWindowController>();
            _exampleWindowController.Open();
        }
    }
}

#endif