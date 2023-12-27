using UnityEngine;

public class PanelController : MonoBehaviour
{
    // Reference to the panel game object
    public GameObject panel;

    // Method to toggle the panel's visibility
    public void TogglePanel()
    {
        // Toggle the active state of the panel
        panel.SetActive(!panel.activeSelf);
    }
}
