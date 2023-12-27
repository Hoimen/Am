using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public Text priceTxt;
    public GameObject ShopManager;

    void Update()
    {
        priceTxt.text = "Price: $" + ShopManager.GetComponent<shopmanagerscript>().shopItems[2, ItemID].ToString();
    }
}
