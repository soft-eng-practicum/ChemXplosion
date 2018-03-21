using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour {

    public static bool isComplete_Puzzle_2 = false;
    public GameObject[] puzzle2Objects;
    public Pour[] pours;
    public GameObject explosion; 

    private void Start()
    {
        pours = new Pour[puzzle2Objects.Length];
        for (int i = 0; i < puzzle2Objects.Length; i++)
        {
            pours[i] = puzzle2Objects[i].GetComponent<Pour>();
        }
        
    }

    private void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Accept")
        {
            for (int i = 0; i < puzzle2Objects.Length; i++)
            {
                if (pours[i].isPoured)
                {
                    isComplete_Puzzle_2 = true;
                }
            }
        }
        else if (other.tag == "Deny")
            for (int i = 0; i < puzzle2Objects.Length; i++)
            {
                if (pours[i].isPoured)
                {
                    isComplete_Puzzle_2 = false;
                    Invoke("Explosion", 4);
                }
            }
    }

    public void Explosion()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

    /*
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
    }*/
}