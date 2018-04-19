using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public Material[] mats;

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

        if (PuzzleOneTable.isComplete_Puzzle_1)
        {
            Invoke("ChangeMaterial", 1.5f);
        }

    }

    void ChangeMaterial()
    {
        rend.sharedMaterial = mats[1];
    }
}