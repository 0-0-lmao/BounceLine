using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRender : MonoBehaviour
{
    public Transform ball;
    public LineRenderer line;
    private Vector3 desiredPos;

    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //set potion start
        line.SetPosition(0, ball.position);
        for (int i = 1; i < line.positionCount; i++)
        {
            //find out if distance is greater than Dist variable
            if (Vector3.Distance(line.GetPosition(i-1), line.GetPosition(i)) > dist)
            {
                //Get position needed
                desiredPos = Vector3.Lerp(ball.position, line.GetPosition(i), i / (float)line.positionCount);
                desiredPos.z = 0f;
                //Set Position Needed
                line.SetPosition(i, desiredPos);
            }

            /*if (i >= line.positionCount - 1)
            {
                desiredPos = Vector3.Lerp(ball.position, end.position, 1);
            }
            */
            //Debug.Log(i);
        }
        //if (line.GetPosition(line.positionCount) 
        //line.SetPosition(line.positionCount-1, end.position);
    }
}
