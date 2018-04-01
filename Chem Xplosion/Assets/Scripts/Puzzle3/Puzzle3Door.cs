using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3Door : MonoBehaviour {

    private Animator dAnimate;
    public static bool puzzleThreeComplete;
    // Use this for initialization
    void Start()
    {
        dAnimate = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        puzzleThreeComplete = Puzzle3.isComplete_Puzzle_3;

        if (puzzleThreeComplete == true)
        {
            dAnimate.SetBool("open", true);
        }
    }
}
