using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDrop : MonoBehaviour
{
    [SerializeField] float turningSpeed;
    float mouseX;

    private void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        if(Input.GetMouseButton(0))
        {   //Rotate sürekli ekler.
            transform.Rotate(0, mouseX * turningSpeed * Time.deltaTime, 0);
        }
    }
}
