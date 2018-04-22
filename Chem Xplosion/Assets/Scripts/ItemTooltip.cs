using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemTooltip : MonoBehaviour
{

    public string info;
    public string leftclick;
    public string rightclick;
    public GameObject tooltip;
    public GameObject mousetooltip;
    public GameObject leftclickobject;
    public GameObject rightclickobject;
    public bool mousetooltiptest;
    bool test = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (tooltip.activeSelf)
        {
            tooltip.transform.position = Input.mousePosition;
        }
    }

    void OnMouseOver()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 2.5f))
        {
            tooltip.transform.GetChild(0).GetComponent<Text>().text = info;
            tooltip.SetActive(true);
            if(mousetooltiptest)
            {
                
                //mousetooltip.transform.GetChild(2).GetComponent<Text>().text = rightclick;
                mousetooltip.SetActive(true);
                leftclickobject.transform.GetChild(0).GetComponent<Text>().text = leftclick;
                rightclickobject.transform.GetChild(0).GetComponent<Text>().text = rightclick;
            }
        }

    }

    void OnMouseExit()
    {
        tooltip.SetActive(false);
        if (mousetooltiptest)
        {
            mousetooltip.SetActive(false);
        }
    }
}
