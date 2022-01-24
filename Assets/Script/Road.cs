using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public GameObject Roadpart;
    public Vector3 lastpart;
    public float offset = 1f;
    private int Roadcount = 0;

    void Awake()
    {
        InvokeRepeating("CreatnewROadpart" , .9f, .2f);
    }

    public void CreatnewROadpart()
    {
        Vector3 b = Vector3.zero;
        float chance = Random.Range(0, 100);
        if(chance>50)
        {
            b = new Vector3(lastpart.x - offset, lastpart.y, lastpart.z );

        }
        else
        {
            b = new Vector3(lastpart.x , lastpart.y, lastpart.z + offset);
        }

        GameObject g = Instantiate(Roadpart, b, Quaternion.Euler(0, 0, 0));
        lastpart = g.transform.position;
        Roadcount++;
        if (Roadcount % 5 == 0)
        {
            g.transform.GetChild(0).gameObject.SetActive(true);
        }
    }


   
}
