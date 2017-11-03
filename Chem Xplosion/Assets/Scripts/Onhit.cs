using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onhit : MonoBehaviour {
	public GameObject door;
	public static int counter = 0;
	public GameObject explosion;
	public static bool isComplete_Puzzle_1 = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (counter == 2) {
			destroyLock ();
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

	void destroyLock(){
	//	Destroy (door);
		Instantiate (explosion,transform.position, Quaternion.identity);
		Destroy (gameObject);
		isComplete_Puzzle_1 = true;
	}
}

