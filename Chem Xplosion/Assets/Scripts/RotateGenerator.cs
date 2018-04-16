using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGenerator : MonoBehaviour {
    public static bool puzzle3Complete; 

    public GameObject gen1;
    public GameObject gen2;
    public GameObject gen3;
    public GameObject gen4;

    private bool playAudio;
    public AudioSource audiosrc;
    public AudioClip generatorNoise;

    // Use this for initialization
    void Start () {
        audiosrc = GetComponent<AudioSource>();
        playAudio = false;
    }
	
	// Update is called once per frame
	void Update () {
        puzzle3Complete = Puzzle3.isComplete_Puzzle_3;
        if (puzzle3Complete)
        {
            gen1.transform.Rotate(0, 1, 0);
            gen2.transform.Rotate(0, -1, 0);
            gen3.transform.Rotate(0, 1, 0);
            gen4.transform.Rotate(0, -1, 0);

            if (!playAudio)
            {
                audiosrc.enabled = true;
                playAudio = true;
            }
        }



    }
}
