using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class HideUI : MonoBehaviour {

    public string buttonName;
    bool visible;
    CanvasGroup canvasGroup;
    public CharacterController characterController;

    // Use this for initialization
    void Start()
    {
        visible = false;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update ()
    {

        if (Input.GetButtonUp(buttonName))
        {
            if(visible)
            {
                Hide();
            }
            else if(!visible)
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
        canvasGroup.interactable = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        characterController.enabled = true;
        characterController.GetComponent<FirstPersonController>().enabled = true;
    }

    void Show()
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        visible = true;
        canvasGroup.interactable = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        characterController.enabled = false;
        characterController.GetComponent<FirstPersonController>().enabled = false;
    }
}
