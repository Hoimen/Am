using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public GameObject objectToAppear;

    private void OnMouseDown()
    {
        if (objectToAppear != null)
        {
            objectToAppear.SetActive(true);
        }
    }
}