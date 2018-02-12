﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleOneTable : MonoBehaviour {

	public static bool isComplete_Puzzle_1 = false;
	public static int puzzleOneCounter = 0;
	public GameObject[] puzzleOneItems;

	void Start () {
		
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Accept") {
			puzzleOneCounter++;
		}
		if (col.gameObject.tag == "Deny") {
			puzzleOneCounter--;
		}
		if (col.gameObject.tag == "Test"){
			puzzleOneCounter++;
		}
	}

	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "Accept") {
			puzzleOneCounter--;
		}
		if (col.gameObject.tag == "Deny") {
			puzzleOneCounter++;
		}

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("e") && puzzleOneCounter == 3) {
			isComplete_Puzzle_1 = true;
			foreach(GameObject item in puzzleOneItems)
			{
				Destroy(item);
			}
		}
	}
}
