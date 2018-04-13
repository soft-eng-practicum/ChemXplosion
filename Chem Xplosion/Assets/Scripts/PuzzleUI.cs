using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleUI : MonoBehaviour {

    public string buttonName;
    bool visible;
    CanvasGroup canvasGroup;

    // Use this for initialization
    void Start()
    {
        visible = true;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonUp(buttonName))
        {
            if (visible)
            {
                Hide();
            }
            else if (!visible)
            {
                Show();
            }


        }

    }

    void Hide()
    {
        canvasGroup.alpha = 0f; //this makes everything transparent
        canvasGroup.blocksRaycasts = false; //this prevents the UI element to receive input events
        visible = false;
    }

    void Show()
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        visible = true;
    }
}
