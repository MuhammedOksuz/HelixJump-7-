using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDragMove : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    float moveXCounter;
    private void Update()
    {
        moveXCounter = Input.GetAxis("Mouse X");
        if(Input.GetMouseButton(0))
        {   //Rotate sürekli üzerine ekler.
            transform.Rotate(0, moveXCounter * rotateSpeed * Time.deltaTime, 0);
        }
    }
}
