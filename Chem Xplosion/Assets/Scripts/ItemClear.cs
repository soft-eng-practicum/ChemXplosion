using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClear : MonoBehaviour {
	public static bool okToClear = false;  
	public static int ascounter = 0;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		okToClear = PuzzleOneTable.isComplete_Puzzle_1;
	}


	void OnCollisionStay(Collision col)
	{
		if(okToClear == true){
			foreach (ContactPoint contact in col.contacts) {
				Destroy (col.gameObject);
				ascounter++;
			}
		}
	}

}
