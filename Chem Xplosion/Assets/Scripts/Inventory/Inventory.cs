using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public Image[] itemImages = new Image[numItemSlots];
    public GameObject[] items = new GameObject[numItemSlots];


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
                itemToAdd.SetActive(false); // Hides item in game, does not destroy it
                print(itemToAdd.name + " added to item slot " + i);
                //creating new game object, placing it in correct area, adding correct components needed for inventory item
                GameObject image = new GameObject();
                itemImages[i] = image.AddComponent<Image>();
                image.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 40);
                image.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 40);
                image.AddComponent<CanvasGroup>();
                image.AddComponent<DragDrop>();
                itemImages[i].enabled = true;
                itemImages[i].sprite = items[i].GetComponent<InventoryItem>().chemSprite;
                image.transform.SetParent(GameObject.Find("Slot" + i).transform);
                image.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
                image.name = items[i].name;
                break;
            }
        
        }
   
    }


    public void RemoveItem(Item itemToRemove)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToRemove)
            {
                items[i] = null;
                itemImages[i].sprite = null;
                itemImages[i].enabled = false;
                return;
            }
        }
    }
}
