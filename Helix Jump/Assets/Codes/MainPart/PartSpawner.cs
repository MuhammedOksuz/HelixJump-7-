using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartSpawner : MonoBehaviour
{
    [SerializeField] GameObject spawningPart;
    [SerializeField] Vector3 firstObjectPos;
    [SerializeField] int maxObjectCount;
    [SerializeField] float y_Distance; 
    void Start()
    {
        PartCreater();
    }

    void PartCreater()
    {
        for (int i = 0; i < maxObjectCount; i++)
        {
            GameObject part = Instantiate(spawningPart, Vector3.zero, spawningPart.transform.rotation);
            part.transform.parent = transform; // transform bu objeyi temsil ediyor. Yani bu objeyi part'ýn parent'ý yapýyoruz.
            if (i == 0)
            {
                part.transform.position = firstObjectPos;
            }
            else
            {
                part.transform.position = firstObjectPos - new Vector3(0, y_Distance*i, 0);
            }
        }
    }

}
