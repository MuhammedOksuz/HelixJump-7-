using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartBuilder : MonoBehaviour
{
    [SerializeField] GameObject bluePart, redPart;
    [SerializeField] int minBluePart, minEmptyPart;
    [SerializeField] int rotationYChangingAmount;
    int partCount = 12;
    private bool areThereChanges = false;

    private void Start()
    {
        partBuilder();
    }
    void partBuilder()
    {
                int rotation_Y = 0;
        for (int i = 0; i < partCount; i++)
        {
            do
            {
                areThereChanges = false;
                int rnd = Random.Range(0, 10);
                Quaternion rotation = Quaternion.Euler(new Vector3(0, 0, rotation_Y));
                if (rnd >= 0 && rnd <= 5)
                {
                    PartSpawn(0, rotation);
                }
                else if (rnd == 6)
                {
                    PartSpawn(1, rotation);
                }
                else if (rnd >= 7 && rnd < 10)
                {
                    PartSpawn(2, rotation);
                }
            } while (!areThereChanges);
            
            rotation_Y += rotationYChangingAmount;
        }
    }
    void PartSpawn(int whichOne, Quaternion rotation)
    {
        areThereChanges = true;
        GameObject whichPart = null;

        switch(whichOne)
        {
            case 0:
                whichPart = bluePart;
                break;
            case 1:
                whichPart = redPart;
                break;
            case 2:
                whichPart = null;
                break;
        }
        if (whichPart != null)
        {
            GameObject build = Instantiate(whichPart, transform);
            build.transform.localPosition = Vector3.zero;
            build.transform.localRotation = rotation;
        }
    }
}
