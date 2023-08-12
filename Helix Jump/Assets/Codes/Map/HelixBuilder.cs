using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixBuilder : MonoBehaviour
{

    [SerializeField] GameObject bluePart;
    [SerializeField] GameObject redPart;
    [SerializeField] int maxSpawnCount;
    [SerializeField] int minBlueCount;
    [SerializeField] int minEmtyCount,rotationZChangingAmount;


    private bool areThereChanges = false;

    private void Start()
    {
        PossitionFinderAndBuilder();
    }
    void PossitionFinderAndBuilder()
    {
        //int blueCount=0, redCount=0, emptyCount=0;
        //blueCount += minBlueCount;
        //emptyCount += minEmtyCount;

        //int temp = maxSpawnCount - blueCount - emptyCount - redCount;

        //for (int i = 0; i < temp; i++)
        //{
        //    switch (Random.Range(0,3))
        //    {
        //        case 0:
        //            blueCount++;
        //            break;
        //        case 1:
        //            redCount++;
        //            break;
        //        case 2:
        //            emptyCount++;
        //            break;

        //    }
        //}

        int rotatioZ = 0;
        for (int i = 0; i < maxSpawnCount; i++)
        {
            int change=0;
          
            do
            {
                areThereChanges = false;
                int rnd=  Random.Range(0, 10);
                Quaternion  objRotation= Quaternion.Euler(new Vector3(0, 0, rotatioZ));

                if (rnd > 0 && rnd < 5 )
                {
                    partSpawn(0, objRotation);
                }
                else if (rnd > 5 && rnd < 7 )
                {
                    partSpawn(1, objRotation);
                }
                else if (rnd > 7 && rnd < 10 )
                {
                    partSpawn(2, objRotation);
                }
                
                if (change > 20)
                {
                    partSpawn(2, objRotation);
                }

                change++;

            } while (!areThereChanges);

            rotatioZ += rotationZChangingAmount;
        }

    }

    void partSpawn(int wichOne, Quaternion rot)
    {
        areThereChanges = true;
        GameObject spawningGo=null;

        switch (wichOne)
        {
            case 0:
                spawningGo = bluePart;
                break;
            case 1:
                spawningGo = redPart;
                break;
            case 2:
                spawningGo = null;
                break;
        }

        if (spawningGo != null)
        {
            GameObject part = Instantiate(spawningGo, transform);
            part.transform.localPosition = Vector3.zero;
            part.transform.localRotation = rot;
        }



    }
}
