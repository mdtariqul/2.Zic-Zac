using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutButton : MonoBehaviour
{
    public void Button_Clicked()
    {
        SceneManager.LoadScene("About");
    }
   
 
}
