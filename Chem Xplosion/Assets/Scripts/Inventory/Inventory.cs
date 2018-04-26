using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{

    
    public Image[] itemImages = new Image[numItemSlots];
    public GameObject[] items = new GameObject[numItemSlots];
    public Vector3 dropPoint;

    public const int numItemSlots = 12;

    public void AddItem(GameObject itemToAdd)
    {
        int i = 0;
        while (i < items.Length)
        {
            if (items[i] != null)
            {
                i++;
            }
            else
            {
                items[i] = GameObject.Find(itemToAdd.name);
                items[i].name = itemToAdd.name;
                itemToAdd.transform.position = new Vector3(-65, 15, 30); // Hides item in game, does not destroy it
                print(itemToAdd.name + " added to item slot " + i);
                //creating new game object, placing it in correct area, adding correct components needed for inventory item
                GameObject image = new GameObject();
                itemImages[i] = image.AddComponent<Image>();
                //image.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50);
                //image.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 50);
                image.AddComponent<CanvasGroup>();
                image.AddComponent<DragDrop>();
                image.AddComponent<RemoveFromInventory>();
                image.GetComponent<RemoveFromInventory>().tooltip = GetComponent<Tooltip>().tooltip;
                image.GetComponent<RemoveFromInventory>().mousetooltip = GetComponent<Tooltip>().mousetooltip;
                image.GetComponent<RemoveFromInventory>().leftclickobject = GetComponent<Tooltip>().leftclickobject;
                image.GetComponent<RemoveFromInventory>().rightclickobject = GetComponent<Tooltip>().rightclickobject;
                itemImages[i].enabled = true;
                itemImages[i].sprite = items[i].GetComponent<InventoryItem>().chemSprite;
                image.transform.SetParent(GameObject.Find("Slot" + i).transform);
                image.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
                image.name = items[i].name + "1";
                break;
            }
           
        }
   
    }


    public void RemoveItem(GameObject itemToRemove)
    {
        string item = itemToRemove.name.Remove(itemToRemove.name.Length - 1);
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject chemical = GameObject.Find(item);
        for (int i = 0; i < items.Length; i++)
        {
            print("Item{i}: " + items[i]);
            print("ItemToRemove: " + itemToRemove);

            if (items[i] == chemical)
            {
                GameObject.Find(item).transform.position = player.transform.position + player.transform.forward *.7f + Vector3.up;  
                Destroy(itemImages[i]);
                items[i] = null;
                Destroy(itemToRemove);
                return;
            }
       
        }
    }
}
