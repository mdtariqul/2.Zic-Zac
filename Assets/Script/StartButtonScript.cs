using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButtonScript : MonoBehaviour
{

public void Start_Button_Click()
    {
        SceneManager.LoadScene("Game secne");
    }

}





/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameEndScript : MonoBehaviour
{
    private Rigidbody rb;
    public Rigidbody rb;
    float x;

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        // Debug.Log(rb.transform.position.y);
        x = rb.transform.position.y;
        if (x > 5.0)
        {
            Debug.Log("hi fjhngbnhjbngh");
            SceneManager.LoadScene("start scene");
        }
    }
}
*/