using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pour : MonoBehaviour{

    private Animator animate;
    public Pickup pickup;
    public bool isPoured; 

    // Use this for initialization
    void Start(){
        this.isPoured = false;
        animate = GetComponent<Animator>();
        this.pickup = GetComponent<Pickup>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetButtonDown("e") && this.pickup.isGrabbed == true){
            this.animate.SetBool("poured", true);
            this.isPoured = true;
        }
        if (Input.GetButtonUp("e")){
            this.animate.SetBool("poured", false);
            this.isPoured = false;
        }
    }
}
