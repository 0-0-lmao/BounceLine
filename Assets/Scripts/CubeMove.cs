using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float scaler;

    private void OnTriggerEnter(Collider Other)
    {
        Debug.Log("Hit");
        transform.position = new Vector3(transform.position.x, transform.position.y + scaler, transform.position.z);
        transform.position = new Vector3(transform.position.x, transform.position.y - scaler, transform.position.z);


    }
}
