using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddtoInventory : MonoBehaviour
{

    Inventory inventory;
    public GameObject selected;

    // Use this for initialization
    void Start()
    {

        inventory = GameObject.Find("InventoryCanvas").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 2.5f))
            {

                if (hit.collider.gameObject.tag == "Pickupable" || hit.collider.gameObject.tag == "Deny" || hit.collider.gameObject.tag == "Accept")
                {
                    selected = GameObject.Find(hit.collider.name);
                    print("additem");
                    inventory.AddItem(selected);
                    GetComponent<Rigidbody>().useGravity = true;
                    //  selected.SetActive(false);
                    GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                }
            }

        }

    }
}