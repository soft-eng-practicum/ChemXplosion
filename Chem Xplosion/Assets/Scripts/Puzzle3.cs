using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3 : MonoBehaviour {

    public static bool isComplete_Puzzle_3 = false;
    public GameObject[] puzzle3Objects;
    public Pour[] pours;
    public GameObject explosion;

    private void Start()
    {
        pours = new Pour[puzzle3Objects.Length];
        for (int i = 0; i < puzzle3Objects.Length; i++)
        {
            pours[i] = puzzle3Objects[i].GetComponent<Pour>();
        }

    }

    private void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Accept")
        {
            for (int i = 0; i < puzzle3Objects.Length; i++)
            {
                if (pours[i].isPoured)
                {
                    isComplete_Puzzle_3 = true;
                }
            }
        }
        else if (other.tag == "Deny")
            for (int i = 0; i < puzzle3Objects.Length; i++)
            {
                if (pours[i].isPoured)
                {
                    isComplete_Puzzle_3 = false;
                    Invoke("Explosion", 4);
                }
            }
    }

    public void Explosion()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
