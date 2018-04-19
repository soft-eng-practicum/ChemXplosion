using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Text : MonoBehaviour {
	
	public Text myText;

	public static int itemCounter;

	public static int tempTimer;

	public static int chestCounter;

	public static bool test;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tempTimer = timer.toggleTimer;

		chestCounter = ItemClear.ascounter;

		test = ItemClear.okToClear;


		myText.text = ("Item Count: " + itemCounter );
	}
}
