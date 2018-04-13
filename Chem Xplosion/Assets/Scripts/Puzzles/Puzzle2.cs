using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour {

    public static bool isComplete_Puzzle_2 = false;
    public GameObject[] puzzle2Objects;
    public Pour[] pours;
    public GameObject explosion;
    public CanvasGroup canvasGroup;
    bool visible;
    bool inside = false;

    private void Start()
    {
        visible = false;
        pours = new Pour[puzzle2Objects.Length];
        for (int i = 0; i < puzzle2Objects.Length; i++)
        {
            pours[i] = puzzle2Objects[i].GetComponent<Pour>();
        }
        
    }

    private void Update()
    {
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
    }

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
        {
            for (int i = 0; i < puzzle2Objects.Length; i++)
            {
                if (pours[i].isPoured)
                {
                    isComplete_Puzzle_2 = false;
                    Invoke("Explosion", 4);
                }
            }
        }
    }

    void Hide()
    {
        canvasGroup.alpha = 0f; //this makes everything transparent
        canvasGroup.blocksRaycasts = false; //this prevents the UI element to receive input events
        visible = false;
    }

    void Show()
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        visible = true;
    }

    public void Explosion()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

}