using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour {

    public static bool isComplete_Puzzle_2 = false;
    public static int puzzleTwoCounter = 0;
    public GameObject[] puzzleTwoItems;

    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Accept")
        {
            puzzleTwoCounter++;
        }
        if (col.gameObject.tag == "Deny")
        {
            puzzleTwoCounter--;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Accept")
        {
            puzzleTwoCounter--;
        }
        if (col.gameObject.tag == "Deny")
        {
            puzzleTwoCounter++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleTwoCounter == 1)
        {
            isComplete_Puzzle_2 = true;
            foreach (GameObject item in puzzleTwoItems)
            {
                Destroy(item);
            }
        }
    }
}
