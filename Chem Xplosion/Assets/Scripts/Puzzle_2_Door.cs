using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_2_Door : MonoBehaviour {

    public Animator dAnimate;
    public static bool puzzleTwoComplete;
    // Use this for initialization
    void Start()
    {
        dAnimate = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        puzzleTwoComplete = Puzzle2.isComplete_Puzzle_2;

        if (puzzleTwoComplete == true)
        {
            dAnimate.SetBool("open", true);
        }
    }
}
