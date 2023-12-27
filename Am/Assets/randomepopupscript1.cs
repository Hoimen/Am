using System.Collections;
using UnityEngine;

public class TogglePanel : MonoBehaviour
{
    public GameObject panelToToggle;
    public float toggleInterval = 30f;

    void Start()
    {
        StartCoroutine(TogglePanelCoroutine());
    }

    IEnumerator TogglePanelCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(toggleInterval);

            // Toggle the visibility of the panel
            if (panelToToggle != null)
            {
                panelToToggle.SetActive(!panelToToggle.activeSelf);
            }
        }
    }
}
