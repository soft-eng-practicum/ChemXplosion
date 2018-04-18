using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleOneTable : MonoBehaviour
{

    public static bool isComplete_Puzzle_1 = false;
    public static int puzzleOneCounter = 0;
    public GameObject[] puzzleOneItems;
    public GameObject explosion;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Accept")
        {
            puzzleOneCounter++;
        }
        if (col.gameObject.tag == "Deny")
        {
            
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Accept")
        {
            for (int i = 0; i < puzzleOneItems.Length; i++)
            {
                
            }
        }
        else if (other.tag == "Deny")
            for (int i = 0; i < puzzleOneItems.Length; i++)
            {
                
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

        //press to solve puzzle
        if (Input.GetButtonDown("e") && puzzleOneCounter == 1)
        {
            Invoke("DestroyChems", 2);
        }
    }

}