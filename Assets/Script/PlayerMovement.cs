using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
   
    private bool walkingright =!true;
    void Awake()
    {
       // Thread.Sleep(10000); 

        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.transform.position = transform.position + transform.forward * 3 * Time.deltaTime;
       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Change();
        }
    }

    private void Change()
    {
        walkingright = !walkingright;
        if (walkingright)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);

        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
               
    }
}
