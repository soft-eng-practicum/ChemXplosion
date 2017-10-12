using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onhit : MonoBehaviour {
	public GameObject door;
	public static int counter =0;
	public GameObject explosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (counter == 3) {
			destroyDoor ();
		}
	}
		void OnCollisionEnter(Collision col)
		{
			if (col.gameObject.tag == "Pickupable")
			{
			counter++;
			}
		}
	void destroyDoor(){
		Destroy (door);
		Instantiate (explosion,transform.position, Quaternion.identity);
		Invoke ("destroyExplosion", 3);
	}
	void destroyExplosion(){
		Destroy (explosion);
	}
	}

