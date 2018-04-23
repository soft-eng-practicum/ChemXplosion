using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleporter : MonoBehaviour {
    public GameObject ps;
    Text winGameText;

    private void Start()
    {
        winGameText = GameObject.Find("WinText").GetComponent<Text>();
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
                winGameText.text = "Congratulations, you have completed level 1";//Alter this to begin level 2 scene;
                StartCoroutine("winText");
                winGameText.text = "";
                print("winning");
            }
                
        }
    }

    private IEnumerator winText() {
        yield return new WaitForSeconds(2);
    }
}
