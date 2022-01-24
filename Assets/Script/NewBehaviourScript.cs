using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{

     public Rigidbody rb;
     float x;

   
    void Update()
    {
        rb = GetComponent<Rigidbody>();
       
        x = rb.transform.position.y;
        
        if (x < -20.0f)
        {
           
            SceneManager.LoadScene("Game Over");
        }
    }
}
