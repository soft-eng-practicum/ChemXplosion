using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {
    public GameObject ps;
    private void Start()
    {
      // ps = GetComponentInChildren<ParticleSystem>();
    }
    void Update()
    {
        if (PuzzleOneTable.isComplete_Puzzle_1 &&
            Puzzle2.isComplete_Puzzle_2 &&
            Puzzle3.isComplete_Puzzle_3 &&
            PuzzleFourTable.isComplete_Puzzle_4)
        {//If the four puzzles have been completed, activate the teleporter.
            ps.gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (PuzzleOneTable.isComplete_Puzzle_1 &&
            Puzzle2.isComplete_Puzzle_2 &&
            Puzzle3.isComplete_Puzzle_3 &&
            PuzzleFourTable.isComplete_Puzzle_4)
            {
                print("Level One Complete");//Alter this to begin level 2 scene;
            }
                
        }
    }
}
