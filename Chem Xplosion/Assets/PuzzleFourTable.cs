using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFourTable : MonoBehaviour
{

    public static bool isComplete_Puzzle_4 = false;
    public static int puzzleFourCounter = 0;
    public GameObject[] puzzleFourItems;

    void Start()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Accept")
        {
            puzzleFourCounter++;
        }
        if (col.gameObject.tag == "Deny")
        {
            puzzleFourCounter--;
        }
        if (col.gameObject.tag == "Test")
        {
            puzzleFourCounter++;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Accept")
        {
            puzzleFourCounter--;
        }
        if (col.gameObject.tag == "Deny")
        {
            puzzleFourCounter++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("e") && puzzleFourCounter == 1)
        {
            isComplete_Puzzle_4 = true;
            foreach (GameObject item in puzzleFourItems)
            {
                Destroy(item);
            }
        }
    }
}
