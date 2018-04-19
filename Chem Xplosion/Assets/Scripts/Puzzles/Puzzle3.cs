using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3 : MonoBehaviour {

    public static bool isComplete_Puzzle_3 = false;
    public GameObject[] puzzle3Objects;
    public GameObject explosion;
    public GameObject flaskPrefab;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Accept" && Input.GetButtonDown("e"))
        {
            Instantiate(flaskPrefab, new Vector3(-58.62f, 1.35f, -.57f), Quaternion.identity);
            //flaskPrefab.transform.position = new Vector3(-58.62f, 1.35f, -.57f);
            //flaskPrefab.transform.Rotate(90, 0, 0);
            flaskPrefab.GetComponent<Pour>().enabled = true;
            isComplete_Puzzle_3 = true;
            DestroyChems();
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
        foreach (GameObject item in puzzle3Objects)
        {
            if(item != null)
                Destroy(item);

        }
    }
}
