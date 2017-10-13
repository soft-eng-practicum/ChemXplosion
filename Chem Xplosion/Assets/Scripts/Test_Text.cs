using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Text : MonoBehaviour {
	
	public Text myText;

	public static int itemCounter;

	public static int tempTimer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		itemCounter = Onhit.counter;

		tempTimer = timer.toggleTimer;


		myText.text = ("Item Count: " + itemCounter);
	}
}
