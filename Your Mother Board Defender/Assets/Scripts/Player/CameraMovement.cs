using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform target;
    public float smoothTime;
    public Vector3 yVelocity;
    void Update()
    {
        Vector3 newPosition = Vector3.SmoothDamp(transform.position, target.position ,ref yVelocity, smoothTime);
        newPosition.z = -10;
        transform.position = newPosition;
    }
}
