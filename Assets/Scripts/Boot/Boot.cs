using UI;
using UI.UISystem;
using UnityEngine;
using Zenject;

public class Boot : MonoBehaviour
{
    [Inject] private IUIManager _uiManager;
    private TestWindowController _testWindowController;
    
    private void Start()
    {
        _testWindowController = _uiManager.LoadController<TestWindowController>();
        _testWindowController.Open();
    }
}