using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFourTable : MonoBehaviour
{

    public static bool isComplete_Puzzle_4 = false;
    public GameObject[] puzzle4Objects;
    public GameObject explosion;
    public GameObject flaskPrefab;


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Accept" && Input.GetButtonDown("e"))
        {
            Instantiate(flaskPrefab, new Vector3(-48.27f, 1.51f, 19.054f), Quaternion.identity);
            //flaskPrefab.transform.position = new Vector3(-48.27f, 1.51f, 19.054f);
            //flaskPrefab.transform.Rotate(90, 0, 0);
            flaskPrefab.GetComponent<Pour>().enabled = true;
            isComplete_Puzzle_4 = true;
            DestroyChems();
            GameObject.Find("Tooltip").SetActive(false);
            GameObject.Find("MouseTooltip").SetActive(false);
            //flaskPrefab.SetActive(false);

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
        foreach (GameObject item in puzzle4Objects)
        {
            if (item != null)
                Destroy(item);

        }
    }
}
