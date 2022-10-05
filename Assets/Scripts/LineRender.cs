using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRender : MonoBehaviour
{
    public Transform ball, end;
    public LineRenderer line;
    private Vector3 desiredPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, ball.position);
        for (int i = 1; i < line.positionCount-1; i++)
        {
            desiredPos = Vector3.Lerp(ball.position, end.position, i / (float)line.positionCount);

            line.SetPosition(i, desiredPos);

            if (i >= line.positionCount - 1)
            {
                desiredPos = Vector3.Lerp(ball.position, end.position, 1);
            }
            //
        }
        line.SetPosition(line.positionCount-1, end.position);
    }
}
