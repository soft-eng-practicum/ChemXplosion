using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleOneTable : MonoBehaviour
{

    public static bool isComplete_Puzzle_1 = false;
    public static int puzzleOneCounter = 0;
    public Pour[] pours;
    public GameObject[] puzzleOneItems;
    public GameObject explosion;


    void Start()
    {
        pours = new Pour[puzzleOneItems.Length];
        for (int i = 0; i < puzzleOneItems.Length; i++)
        {
            pours[i] = puzzleOneItems[i].GetComponent<Pour>();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Accept")
        {
            for (int i = 0; i < puzzleOneItems.Length; i++)
            {
                if (pours[i].isPoured)
                {
                    isComplete_Puzzle_1 = true;
                }
            }
        }
        else if (other.tag == "Deny")
            for (int i = 0; i < puzzleOneItems.Length; i++)
            {
                if (pours[i].isPoured)
                {
                    isComplete_Puzzle_1 = false;
                    Invoke("Explosion", 4);
                }
            }
    }

    public void Explosion()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

    void DestroyChems()
    {
        foreach (GameObject item in puzzleOneItems)
        {
            Destroy(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isComplete_Puzzle_1 == true)
        {
            Invoke("DestroyChems", 2);
        }
    }
}