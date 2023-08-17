using UnityEngine;

public class ObjectInteractionScript : MonoBehaviour
{
    public GameObject gameObjectToHide;

    private void OnMouseDown()
    {
        // Toggle the visibility of the object to hide
        gameObjectToHide.SetActive(!gameObjectToHide.activeSelf);
    }
}