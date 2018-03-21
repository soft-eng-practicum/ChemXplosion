using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_4_Door : MonoBehaviour
{

    private Animator dAnimate;
    public static bool puzzleFourComplete;
    // Use this for initialization
    void Start()
    {
        dAnimate = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        puzzleFourComplete = PuzzleFourTable.isComplete_Puzzle_4;

        if (puzzleFourComplete == true)
        {
            dAnimate.SetBool("open", true);
        }
    }
}
