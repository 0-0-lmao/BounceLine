using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float scaler;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        for (int i = 0; i < 15; i++)
        {
            //transform.localScale += new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z,);
        }
        for (int i = 0; i < 15; i++)
        {
            //transform.localScale -= .1f;
        }


    }
}
