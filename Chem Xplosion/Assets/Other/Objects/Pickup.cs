using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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
    Text itemMouseOver;
    // Use this for initialization
    void Start () {
		hands = GameObject.Find ("PickupLoc").transform;
		player = GameObject.Find ("Player");
        itemMouseOver = GameObject.Find("ItemMouseOver").GetComponent<Text>();
	}

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 2.5f))
        {
            if (hit.collider.gameObject.tag == "Pickupable" || hit.collider.gameObject.tag == "Deny" || hit.collider.gameObject.tag == "Accept")
            {
                itemMouseOver.text = hit.collider.gameObject.name;
            }
            else
            {
                itemMouseOver.text = "";
            }
            if (Input.GetButtonDown("Fire1") && isGrabbed == false)
            {

                if (Physics.Raycast(ray, out hit, 2.5f))
                {
                    if (hit.collider.gameObject.tag == "Pickupable" || hit.collider.gameObject.tag == "Deny" || hit.collider.gameObject.tag == "Accept")
                    {
                        this.isGrabbed = true;
                        Grab(hit.collider.gameObject);
                        GetComponent<Rigidbody>().isKinematic = true;
                        selected = hit.collider.gameObject;
                    }
                }


            }
            else if (Input.GetButtonDown("Fire1") && isGrabbed == true)
            {
                isGrabbed = false;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<Rigidbody>().isKinematic = false;
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
        else
        {
            itemMouseOver.text = "";
        }
    }

	void Grab (GameObject o) {
		if (isGrabbed) {
			hold = o;
			o.transform.parent = loc.transform;
		o.GetComponent<Rigidbody> ().useGravity = false;
		o.transform.position = hands.position;
		}
	}

	void OnMouseUp () {
		GetComponent<Rigidbody> ().useGravity = true;
	}
}
