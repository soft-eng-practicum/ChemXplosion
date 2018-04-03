using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFourTable : MonoBehaviour
{

    public static bool isComplete_Puzzle_4 = false;
    public GameObject[] puzzle4Objects;
    public Pour[] pours;
    public GameObject explosion;

    private void Start()
    {
        pours = new Pour[puzzle4Objects.Length];
        for (int i = 0; i < puzzle4Objects.Length; i++)
        {
            pours[i] = puzzle4Objects[i].GetComponent<Pour>();
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Accept")
        {
            for (int i = 0; i < puzzle4Objects.Length; i++)
            {
                if (pours[i].isPoured)
                {
                    isComplete_Puzzle_4 = true;
                }
            }
        }
        else if (other.tag == "Deny")
            for (int i = 0; i < puzzle4Objects.Length; i++)
            {
                if (pours[i].isPoured)
                {
                    isComplete_Puzzle_4 = false;
                    Invoke("Explosion", 4);
                }
            }
    }

    public void Explosion()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
