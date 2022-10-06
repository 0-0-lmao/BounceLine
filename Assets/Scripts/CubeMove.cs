using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    //public float scaler;
    //public AnimationCurve animCurve;
    //private bool bounce;
    private Vector3 newScale;

    private void OnTriggerEnter(Collider Other)
    {
        //Debug.Log("Hit");
        newScale = transform.localScale;
        newScale.y = 1f;
        transform.localScale = newScale;
       
    }

    private void OnTriggerExit(Collider other)
    {
        transform.localScale = new Vector3(1f,1.1f, 1f);
    }
    private void Update()
    {
        /*if (bounce)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + animCurve.Evaluate(scaler), transform.position.z);
            scaler += 0.25f * Time.deltaTime;
            if (scaler >= 1f)
            {
                Debug.Log("Fortnite");
                scaler = 0f;
                transform.position = orginalPos;
                bounce = false;
            }
        }
        */

    }
}
