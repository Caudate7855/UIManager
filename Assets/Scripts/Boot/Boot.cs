using UI;
using UI.UISystem;
using UnityEngine;

public class Boot : MonoBehaviour
{
    private IUIManager _uiManager = new UIManager();
    private TestWindowController _testWindowController;
    
    private void Start()
    {
        _testWindowController = _uiManager.LoadController<TestWindowController>();
        _testWindowController.Open();
    }
}