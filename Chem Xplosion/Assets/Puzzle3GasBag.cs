using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3GasBag : MonoBehaviour {
    private Animator animate;
    public static bool puzzleTwoComplete;
    private bool playAudio;
    AudioSource audiosrc;
    public AudioClip fillNoise;

    // Use this for initialization
    void Start()
    {
        animate = GetComponent<Animator>();
        audiosrc = GetComponent<AudioSource>();
        playAudio = false;
    }

    // Update is called once per frame
    void Update()
    {
        puzzleTwoComplete = PuzzleFourTable.isComplete_Puzzle_4;

        if (puzzleTwoComplete)
        {
            animate.SetBool("expanded", true);

            if (!playAudio)
            {
                audiosrc.PlayOneShot(fillNoise);
                playAudio = true;
            }
        }

    }
}