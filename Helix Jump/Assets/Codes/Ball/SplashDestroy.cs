using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashDestroy : MonoBehaviour
{
    [SerializeField] float splashDestroyTime;
    float splashDestroyCounter;
    private void Start()
    {
        splashDestroyCounter = splashDestroyTime;
    }
    private void Update()
    {
        splashDestroyCounter -= Time.deltaTime;
        if (splashDestroyCounter <= 0)
        {
            Destroy(gameObject);
        }
    }
}
