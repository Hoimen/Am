using System.Collections;
using UnityEngine;

public class HideOnClick2 : MonoBehaviour
{
    public GameObject objectToHide1;
    public GameObject objectToHide2;
    public float hideDuration = 1.0f; // Set to 5 seconds

    private void OnMouseDown()
    {
        StartCoroutine(HideObjectsCoroutine());
    }

    // Coroutine to hide the specified game objects for a duration
    private IEnumerator HideObjectsCoroutine()
    {
        HideObject(objectToHide1);
        HideObject(objectToHide2);

        // Wait for the specified duration
        yield return new WaitForSeconds(hideDuration);

        // Show the game objects again
        ShowObject(objectToHide1);
        ShowObject(objectToHide2);
    }

    // Method to hide the specified game object
    private void HideObject(GameObject obj)
    {
        if (obj != null)
        {
            obj.SetActive(false);
        }
    }

    // Method to show the specified game object
    private void ShowObject(GameObject obj)
    {
        if (obj != null)
        {
            obj.SetActive(true);
        }
    }
}
