using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger3 : MonoBehaviour
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

        if (Puzzle3.isComplete_Puzzle_3)
        {
            Invoke("ChangeMaterial", 1.5f);
        }

    }

    void ChangeMaterial()
    {
        rend.sharedMaterial = mats[1];
    }
}