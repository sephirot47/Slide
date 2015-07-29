using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    private Vector3 lastMousePosition;

    [SerializeField]
    private Brush brush;

	void Start () 
    {
        lastMousePosition = Vector3.zero;
	}
	
	void Update () 
    {
        Paint();
	}

    void Paint()
    {
        Vector2 position = Vector2.zero;
        Vector2 speed = Vector2.zero;

        if (Input.touchCount >= 1)
        {
            position = ScreenManager.ScreenToWorld(Input.touches[0].rawPosition);
            speed = ScreenManager.ScreenToWorld(Input.touches[0].deltaPosition / Input.touches[0].deltaTime);
        }
        else if (Input.GetMouseButton(0))
        {
            position = ScreenManager.ScreenToWorld(Input.mousePosition);
            speed = (ScreenManager.ScreenToWorld(Input.mousePosition) - ScreenManager.ScreenToWorld(lastMousePosition)) / Time.deltaTime;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            brush.ClearLines();
        }

        if(speed != Vector2.zero) brush.DrawLineTo(position, speed);

        lastMousePosition = Input.mousePosition;
    }
}
