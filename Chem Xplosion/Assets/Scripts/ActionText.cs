using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ActionText : MonoBehaviour {

    Text UItext;

    public static string objectText;

	// Use this for initialization
	void Start () {
        UItext = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        UItext.text = objectText;
	}
}
