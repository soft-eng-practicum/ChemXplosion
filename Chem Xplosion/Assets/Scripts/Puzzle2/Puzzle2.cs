using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour {

    public static bool isComplete_Puzzle_2 = false;
    public GameObject[] puzzle2Objects;
    public Pour[] pours;
    public GameObject explosion; 

    private void Start(){
        pours = new Pour[puzzle2Objects.Length];
        for (int i = 0; i < puzzle2Objects.Length; i++){
            pours[i] = puzzle2Objects[i].GetComponent<Pour>();
        }
        
    }

    private void OnTriggerStay(Collider other){
        if (other.tag == "Accept"){
            for (int i = 0; i < puzzle2Objects.Length; i++){
                if (pours[i].isPoured){
                    isComplete_Puzzle_2 = true;
                    for (int j = 0; j < puzzle2Objects.Length; j++) {
                        Destroy(puzzle2Objects[j]);
                    }
                }
            }
        }
        else if (other.tag == "Deny")
            for (int i = 0; i < puzzle2Objects.Length; i++){
                if (pours[i].isPoured){
                    isComplete_Puzzle_2 = false;
                    Invoke("Explosion", 4);
                }
            }
    }

    public void Explosion(){
        Instantiate(explosion, transform.position, transform.rotation);
    }

}