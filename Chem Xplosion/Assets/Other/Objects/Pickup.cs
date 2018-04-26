using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

	Transform hands;
	public GameObject loc;
	public bool isGrabbed = false;
	GameObject player;
	//PlayerController playerController;
	private RaycastHit hit;
	private GameObject hold;
    public Pickup pickup;
    public GameObject selected;
    Inventory inventory;

    // Use this for initialization
    void Start () {
		hands = GameObject.Find ("PickupLoc").transform;
		player = GameObject.Find ("Player");
        inventory = GameObject.Find("InventoryCanvas").GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1") && isGrabbed == false) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit, 2.5f)) {
				if (hit.collider.gameObject.tag == "Pickupable" || hit.collider.gameObject.tag == "Deny" || hit.collider.gameObject.tag == "Accept"){
					this.isGrabbed = true;
					Grab (hit.collider.gameObject);
					GetComponent<Rigidbody> ().isKinematic = true;
                    selected = hit.collider.gameObject;
                }
			}


		} else if ((Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire1")) && isGrabbed == true) {
			this.isGrabbed = false;
			GetComponent<Rigidbody> ().useGravity = true;
			GetComponent<Rigidbody> ().isKinematic = false;
			this.transform.parent = null;
        }
        if (isGrabbed)
        {
            selected.transform.position = GameObject.Find("Grab").transform.position;
        }



        //else if (Input.GetKeyDown(KeyCode.Mouse1) && isGrabbed == true)
        //{
        //    isGrabbed = false;
        //    print("additem");
        //    inventory.AddItem(selected);
        //    GetComponent<Rigidbody>().useGravity = true;
        //    //  selected.SetActive(false);
        //    GetComponent<Rigidbody>().isKinematic = false;
        //    transform.parent = null;

        //}

    }

    void Grab (GameObject o) {
		if (isGrabbed) {
			hold = o;
			//o.transform.parent = loc.transform;
		o.GetComponent<Rigidbody> ().useGravity = false;
		o.transform.position = hands.position;
		}
	}

	void OnMouseUp () {
		GetComponent<Rigidbody> ().useGravity = true;
	}
}
