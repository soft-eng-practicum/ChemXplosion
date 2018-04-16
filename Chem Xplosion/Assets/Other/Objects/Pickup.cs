using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

	public Transform hands;
	public GameObject loc;
	public bool isGrabbed = false;
	GameObject player;
	//PlayerController playerController;
	private RaycastHit hit;
	private GameObject hold;
    public Pickup pickup;
    public GameObject selected;
    // Use this for initialization
    void Start () {
        if(hands == null)
		    hands = GameObject.Find ("PickupLoc").transform;
		player = GameObject.Find ("Player");
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


		} else if (Input.GetButtonDown("Fire1") && isGrabbed == true) {
			isGrabbed = false;
			GetComponent<Rigidbody> ().useGravity = true;
			GetComponent<Rigidbody> ().isKinematic = false;
			this.transform.parent = null;
		//	playerController.isLooking = false;
		} 

		//if (isGrabbed == true) {
		//	playerController.isLooking = true;
		//	float v = Input.GetAxisRaw ("Vertical");
		//	float h = Input.GetAxisRaw ("Horizontal");
		//	hold.transform.Rotate (v, 0, h);
		//}

	}

	public void Grab (GameObject o) {
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
