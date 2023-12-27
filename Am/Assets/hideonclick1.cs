using UnityEngine;

public class HideOnClick1 : MonoBehaviour
{
    public GameObject objectToHide;

    private void OnMouseDown()
    {
        if (objectToHide != null)
        {
            objectToHide.SetActive(false);
        }
    }
}