using UnityEngine;

public class HideOnClick : MonoBehaviour
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
