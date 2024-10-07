using UnityEngine;

namespace UIManager.Samples.NoExtenject_NoAddressables.Scripts
{
    public class Boot : MonoBehaviour
    {
        private readonly IUIManager _uiManager = new UIManager();
        private ExampleWindowController _exampleWindowController;

        private void Start()
        {
            _exampleWindowController = _uiManager.LoadController<ExampleWindowController>();
            _exampleWindowController.Open();
        }
    }
}