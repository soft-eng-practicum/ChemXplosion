using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour {
    public Material[] mats;

    public static int counter;
    Renderer rend;
    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = mats[0];
    }

    // Update is called once per frame
    void Update()
    {

        /*if (PuzzleOneTable.puzzleOneCounter == 0 && PuzzleOneTable.onTable == false)
        {
            rend.sharedMaterial = mats[0];
        }
        else if (PuzzleOneTable.puzzleOneCounter == 1)
        {
            rend.sharedMaterial = mats[1];
        }
        else
        {
            rend.sharedMaterial = mats[2];
        }*/

    }
}

