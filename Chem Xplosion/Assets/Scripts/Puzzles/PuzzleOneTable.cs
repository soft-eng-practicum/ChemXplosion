using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleOneTable : MonoBehaviour
{

    public static bool isComplete_Puzzle_1 = false;
    public static int puzzleOneCounter = 0;
    public static bool onTable = false;
    public GameObject[] puzzleOneItems;
    public CanvasGroup canvasGroup;
    bool visible;
    bool inside = false;


    void Start()
    {
        visible = false;

    }
    void OnCollisionEnter(Collision col)
    {
        onTable = true;
        if (col.gameObject.tag == "Accept")
        {
            puzzleOneCounter++;
        }
        if (col.gameObject.tag == "Deny")
        {
            puzzleOneCounter--;
        }
        if (col.gameObject.tag == "Test")
        {
            puzzleOneCounter++;
        }
    }

    void OnCollisionExit(Collision col)
    {
        onTable = false;
        if (col.gameObject.tag == "Accept")
        {
            puzzleOneCounter--;
        }
        if (col.gameObject.tag == "Deny")
        {
            puzzleOneCounter++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //check for "p" press, to trigger puzzle 
        if (inside && Input.GetKeyDown("p"))
        {
            if (visible)
            {
                Hide();
            }
            else if (!visible)
            {
                Show();
            }
        }

        //press to solve puzzle
        if (Input.GetButtonDown("e") && puzzleOneCounter == 1)
        {
            isComplete_Puzzle_1 = true;
            foreach (GameObject item in puzzleOneItems)
            {
                Destroy(item);
            }
        }
    }

    //check if player is inside collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inside = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inside = false;
        }

    }

    //Hide p1 canvas
    void Hide()
    {
        canvasGroup.alpha = 0f; //this makes everything transparent
        canvasGroup.blocksRaycasts = false; //this prevents the UI element to receive input events
        visible = false;
    }

    //Show p2 canvas
    void Show()
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        visible = true;
    }
}