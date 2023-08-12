using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float jumpForce;
    [SerializeField] GameObject splash;
    [SerializeField] GameObject text;
    bool itCanMove = true;


   
    private void OnCollisionEnter(Collision other)
    {
        if(itCanMove)
        {
            rb.AddForce(Vector3.up * jumpForce);
            GameObject splashBuild = Instantiate(splash, transform.position - new Vector3(0, 0.06f, 0), splash.transform.rotation);
            splashBuild.transform.parent = other.transform;
        }
        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        print(materialName);
        if(materialName == "Red (Instance)")
        {
            SceneManager.LoadScene("1");
        }
        if(materialName == "Checkered 1 (Instance)")
        {
            text.gameObject.SetActive(true);
            itCanMove = false;
        }
    }
    
    
}
