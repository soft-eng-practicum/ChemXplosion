
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pour : MonoBehaviour
{

    private Animator animate;
    public bool isPoured;

    // Use this for initialization
    void Start()
    {
        isPoured = false;
        animate = GetComponent<Animator>();
        Invoke("DestroyFlask", 3f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("e"))
        {
            //animate.SetBool("poured", true);
            animate.SetBool("poured", true);
            isPoured = true;
        }
        if (Input.GetButtonUp("e"))
        {
            animate.SetBool("poured", false);
            isPoured = false;
        }
    }
    void DestroyFlask()
    {
        Destroy(gameObject);
    }
}