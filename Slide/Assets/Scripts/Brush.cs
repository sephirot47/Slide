﻿using UnityEngine;
using System.Collections;

public class Brush : MonoBehaviour 
{
    private static float maxScale = 5.0f;
    private static float minScale = 0.2f;

    public static Brush CreateBrush(Vector2 position, Vector2 speed)
    {
        Brush brush = (GameObject.Instantiate(Resources.Load("Brush"), position, Quaternion.identity) as GameObject).GetComponent<Brush>();
        
        float scale = speed.magnitude / 1.0f;
        scale = Mathf.Clamp(scale, minScale, maxScale);
        brush.transform.localScale = new Vector3(scale, scale, scale);

        return brush;
    }

	void Start () 
    {
	
	}
	
	void Update () 
    {
	
	}
}
