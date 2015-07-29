using UnityEngine;
using System.Collections;

public class Brush : MonoBehaviour 
{
    private static float maxScale = 0.8f;
    private static float minScale = 0.1f;

    private LineRenderer lineRenderer;
    private int verticesCount;

	void Start () 
    {
        lineRenderer = GetComponent<LineRenderer>();
        verticesCount = 0;
    }
	
	void Update () 
    {
	
	}

    public void DrawLineTo(Vector2 position, Vector2 speed)
    {
        lineRenderer.SetVertexCount(verticesCount + 1);
        lineRenderer.SetPosition(verticesCount, position);
        ++verticesCount;
    }

    public void ClearLines()
    {
        verticesCount = 0;
        lineRenderer.SetVertexCount(0);
    }
}
