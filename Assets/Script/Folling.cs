using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folling : MonoBehaviour
{
    public Transform target;
    private Vector3 ofset;

    void Awake()
    {
        ofset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        transform.position = target.position + ofset;
    }
}
   
