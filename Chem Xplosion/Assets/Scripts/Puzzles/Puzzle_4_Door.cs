using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_4_Door : MonoBehaviour
{

    private Animator dAnimate;

    public static bool is_Complete_Puzzle_4;

    private bool playAudio;
    AudioSource audiosrc;
    public AudioClip DoorOpen;
    // Use this for initialization
    void Start()
    {
        dAnimate = GetComponent<Animator>();
        audiosrc = GetComponent<AudioSource>();
        playAudio = false;
    }


    // Update is called once per frame
    void Update()
    {
        is_Complete_Puzzle_4 = PuzzleFourTable.isComplete_Puzzle_4;

        if (is_Complete_Puzzle_4 == true)
        {

            dAnimate.SetBool("open", true);

            if (!playAudio)
            {
                audiosrc.PlayOneShot(DoorOpen);
                playAudio = true;
            }
        }
    }
}