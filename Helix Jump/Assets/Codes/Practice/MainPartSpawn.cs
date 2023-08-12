using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPartSpawn : MonoBehaviour
{
    [SerializeField] GameObject MainPart;
    [SerializeField] Vector3 firstPosition;
    [SerializeField] int mainPartCount;
    [SerializeField] float addToBe_Y;
    private void Start()
    {
        MainPartBuilder();
    }
    void MainPartBuilder()
    {
        for (int i = 0; i < mainPartCount; i++)
        {
            GameObject Part = Instantiate(MainPart, Vector3.zero, MainPart.transform.rotation);
            Part.transform.parent = transform;
            if (i == 0)
            {
                Part.transform.position = firstPosition;
            }
            else
            {
                Part.transform.position = firstPosition - new Vector3(0, addToBe_Y * i, 0);
            }
        }
    }
}
