using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RemoveFromInventory : MonoBehaviour
{
    Inventory inventory;


    public void Start()
    {
        inventory = GameObject.Find("InventoryCanvas").GetComponent<Inventory>();

    }

    public void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            print("Hoovering");
            if (Input.GetKeyDown(KeyCode.Mouse1)) {
                inventory.RemoveItem(this.gameObject);
                print("removed" + gameObject.name);

            }
        }
    }
}
