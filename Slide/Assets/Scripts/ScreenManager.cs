using UnityEngine;
using System.Collections;

public class ScreenManager : MonoBehaviour {

	void Start () {}
	void Update () {}

    public static Vector2 WorldToScreen(Vector3 worldPosition)
    {
        Vector3 wp = Camera.main.WorldToScreenPoint(worldPosition);
        return new Vector2(wp.x, wp.y);
    }

    //Function by JFons
    public static Vector3 ScreenToWorld(Vector2 screenPosition) // THIS ONLY WORKS IF THE CAMERA IS AT (0,0) 
    {
        screenPosition.x += Screen.width / 2;
        screenPosition.y += Screen.height / 2;
        return Camera.main.ScreenToWorldPoint(screenPosition);
    }   
}
