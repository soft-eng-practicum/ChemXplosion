using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onhit : MonoBehaviour {
	public GameObject door;
	public static int counter = 0;
	public GameObject explosion;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (counter == 2) {
			destroyDoor ();
		}
	}
		void OnCollisionEnter(Collision col)
		{
		if (col.gameObject.name == "Red" || col.gameObject.name == "Blue" || col.gameObject.tag == "Test")
			{
			counter++;
			Destroy (col.gameObject);
			}

		if (col.gameObject.name == "Green")
		{
			Destroy (gameObject);
		}

		}

	void destroyDoor(){
		Destroy (door);
		Instantiate (explosion,transform.position, Quaternion.identity);
		Destroy (gameObject);
	}
	void destroyExplosion(){
		Destroy (explosion);
	}
	}

