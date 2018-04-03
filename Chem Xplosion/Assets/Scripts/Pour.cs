using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pour : MonoBehaviour
{

    private Animator animate;
    Pickup pickup;
    public bool isPoured;
    private Collider collider; 

    // Use this for initialization
    void Start()
    {
        isPoured = false;
        animate = GetComponent<Animator>();
        pickup = GetComponent<Pickup>();
        collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("e") && pickup.isGrabbed && collider.gameObject)
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
