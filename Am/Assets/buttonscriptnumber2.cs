using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public GameObject secondCanvas;

    void Start()
    {
        // Ensure the second Canvas is initially disabled
        if (secondCanvas != null)
            secondCanvas.SetActive(false);
    }

    public void OpenSecondScreen()
    {
        // Enable the second Canvas when the button is clicked
        if (secondCanvas != null)
            secondCanvas.SetActive(true);
    }
}