using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public Image[] itemImages = new Image[numItemSlots];
    public GameObject[] items = new GameObject[numItemSlots];

    public const int numItemSlots = 12;

    public void AddItem(GameObject itemToAdd) {
        for (int i = 0; i < items.Length; i++) {
            if (items[i] == null) {
                items[i] = GameObject.Find(itemToAdd.name);
                itemToAdd.SetActive(false); // Hides item in game, does not destroy it
                print(itemToAdd.name + " added to item slot " + i);
                //itemImages[i].sprite = itemToAdd.sprite;
                itemImages[i].enabled = true;
                itemImages[i].sprite = items[i].GetComponent<InventoryItem>().chemSprite;
                return;
            }
        }
    }

    public void RemoveItem(Item itemToRemove) {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToRemove)
            {
                items[i] =  null;
                itemImages[i].sprite = null;
                itemImages[i].enabled = false;
                return;
            }
        }
    }
}
