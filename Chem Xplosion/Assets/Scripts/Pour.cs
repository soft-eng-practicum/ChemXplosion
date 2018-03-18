using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pour : MonoBehaviour
{

    private Animator animate;
    public bool poured;
    public Pickup pickup;
    public bool isPoured; 

    // Use this for initialization
    void Start()
    {
        poured = false;
        isPoured = false;
        animate = GetComponent<Animator>();
        pickup = GetComponent<Pickup>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("e") && pickup.isGrabbed == true)
        {
            animate.SetBool("poured", true);
            isPoured = true;
        }
        if (Input.GetButtonUp("e"))
        {
            animate.SetBool("poured", false);
            isPoured = false;
        }
    }
}
