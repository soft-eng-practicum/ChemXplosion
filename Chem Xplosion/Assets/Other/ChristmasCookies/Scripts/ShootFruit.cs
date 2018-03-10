using UnityEngine;
using System.Collections;

public class ShootFruit : MonoBehaviour {


    public void OnMouseEnter()
    {
#if UNITY_IPHONE || UNITY_IOS || UNITY_ANDROID
        if (Input.GetMouseButton(0))
#endif
        GetComponent<BreakFruit>().Run();
    }
}
