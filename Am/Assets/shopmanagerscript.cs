using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class shopmanagerscript : MonoBehaviour
{
    public int[,] shopItems = new int[5, 5];
    public float money;
    public Text MoneyTXT;
    public Text MoneyTXT2; // Add this line

    void Start()
    {
        UpdateMoneyText();

        // ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        // Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 500; // remember to like make 5 more of these for the rooms
        shopItems[2, 4] = 40;
    }

    public void UpdateMoneyText()
    {
        MoneyTXT.text = "Money: $" + money.ToString();
        MoneyTXT2.text = "Money2: $" + money.ToString(); // Add this line
    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        int itemID = ButtonRef.GetComponent<ButtonInfo>().ItemID;

        if (money >= shopItems[2, itemID])
        {
            money -= shopItems[2, itemID];
            UpdateMoneyText();
        }
        else
        {
            Debug.Log("Not enough money to purchase the item with ID " + itemID);
        }
    }
}
