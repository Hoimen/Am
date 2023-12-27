using UnityEngine;

public class ClickToShowPanel : MonoBehaviour
{
    public GameObject panelToToggle;

    void Start()
    {
        // Ensure the panel is initially deactivated
        if (panelToToggle != null)
        {
            panelToToggle.SetActive(false);
        }
    }

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
         
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits the game object
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // Toggle the panel's visibility
                if (panelToToggle != null)
                {
                    panelToToggle.SetActive(!panelToToggle.activeSelf);
                }
            }
        }
    }
}

