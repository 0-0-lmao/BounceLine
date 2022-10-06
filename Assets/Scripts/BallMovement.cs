using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetA, targetB;
    private float ratio;
    public float speed;
    public AnimationCurve height;
    private Vector3 desiredPos;
    private bool right, left;
    public float offset;

    // Update is called once per frame
    void Update()
    {

        if (ratio >= 1)
        {
            left = true;
            right = false;
        }
        else if (ratio <= 0)
        {
            right = true;
            left = false;
        }
        if (right)
            ratio += (speed * Time.deltaTime);
        else if (left)
            ratio += (-speed * Time.deltaTime);
        desiredPos = Vector3.Lerp(targetA.position, targetB.position, ratio);
        desiredPos = new Vector3(desiredPos.x, desiredPos.y + height.Evaluate(ratio) + offset, desiredPos.z);
        transform.position = desiredPos;


    }
}
