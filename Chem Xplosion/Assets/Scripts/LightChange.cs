using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour {
	public Light lt;
	public static bool isPuzzleOneComplete;
	// Use this for initialization
	void Start () {
		lt = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		isPuzzleOneComplete = PuzzleOneTable.isComplete_Puzzle_1;

		if (isPuzzleOneComplete ==  true) {
			lt.color = Color.green;
		}
	}
}
