using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform ballTransform;
    [SerializeField] float smoothRateThat;
    Vector3 distanceBetween;
    private void Start()
    {
        distanceBetween = transform.position - ballTransform.position;
    }
    private void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, distanceBetween + ballTransform.position, smoothRateThat);
        transform.position = newPos;
    }
}
