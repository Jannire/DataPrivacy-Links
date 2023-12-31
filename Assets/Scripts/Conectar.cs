using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conectar : MonoBehaviour
{
    private LineRenderer lr;
    private Transform[] points;
    // Start is called before the first frame update

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }

    public void SetUpLine(Transform[] points)
    {
        lr.positionCount = points.Length;
        this.points = points;
    }

}
