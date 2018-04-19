﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour {

    public static bool isComplete_Puzzle_2 = false;
    public GameObject[] puzzle2Objects;
    public GameObject explosion;
    public GameObject flaskPrefab;


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Accept" && Input.GetButtonDown("e"))
        {
            Instantiate(flaskPrefab);
            flaskPrefab.transform.position = new Vector3(1.863f, 1.41967f, 5.749f);
            flaskPrefab.transform.Rotate(90, 0, 0);
            flaskPrefab.GetComponent<Pour>().enabled = true;
            isComplete_Puzzle_2 = true;
            DestroyChems();
            flaskPrefab.SetActive(false);

        }
        else if (other.tag == "Deny" && Input.GetButtonDown("e"))
        {
            Invoke("Explosion", 1);
        }
    }

    public void Explosion()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

    void DestroyChems()
    {
        foreach (GameObject item in puzzle2Objects)
        {
            Destroy(item);

        }
    }

}