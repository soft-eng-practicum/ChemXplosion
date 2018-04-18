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
                itemToAdd.transform.position = new Vector3(-65.048f ,5.02f,15.314f); // Hides item in game, does not destroy it
                print(itemToAdd.name + " added to item slot " + i);
                //creating new game object, placing it in correct area, adding correct components needed for inventory item
                GameObject image = new GameObject();
                itemImages[i] = image.AddComponent<Image>();
                image.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 40);
                image.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 40);
                image.AddComponent<CanvasGroup>();
                image.AddComponent<DragDrop>();
                image.AddComponent<RemoveFromInventory>();
              //  image.GetComponent<DragDrop>().dropPanel = GameObject.Find("Puzzle 1 Slot Panel").GetComponent<RectTransform>();
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
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = GameObject.Find(itemToRemove.name);
            print("found" + items[i].name);

            if (items[i] == itemToRemove)
            {
                //   GameObject initializeMe = new GameObject();
                string item = itemToRemove.name.Remove(itemToRemove.name.Length - 1);
                GameObject.Find(item).transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + transform.forward + transform.up;
                //initializeMe.name = itemToRemove.name.Remove(itemToRemove.name.Length - 1);
                // GameObject.Find(itemToRemove.name.Remove(itemToRemove.name.Length - 1));
                //initializeMe.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
               // initializeMe.SetActive(true);

                //itemToRemove.name = itemToRemove.name.Remove(itemToRemove.name.Length - 1);
                //itemToRemove = GameObject.Find(itemToRemove.name);
                //itemToRemove.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
                //itemToRemove.SetActive(true); 
                Destroy(itemImages[i]);
               // itemToRemove.name = itemToRemove.name + "1";
                Destroy(itemToRemove);
                return;
            }
        }
    }
}
