using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onhit : MonoBehaviour {
	public GameObject explosion;
	public static bool isComplete_Puzzle_1;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		isComplete_Puzzle_1 = PuzzleOneTable.isComplete_Puzzle_1;
		if (isComplete_Puzzle_1 == true) {
			destroyLock ();
		}
	}
		//void OnCollisionEnter(Collision col)
		//{
		//if (col.gameObject.name == "Red" || col.gameObject.name == "Blue" || col.gameObject.tag == "Test")
		//	{
		//	counter++;
		//	Destroy (col.gameObject);
		//	}

		//if (col.gameObject.name == "Green")
		//{
		//	Destroy (gameObject);
		//}

	//	}

	void destroyLock(){
	//	Destroy (door);
		Instantiate (explosion,transform.position, Quaternion.identity);
		Destroy (gameObject);
		isComplete_Puzzle_1 = true;
	}

}

