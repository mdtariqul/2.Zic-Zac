using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
   public void Back_Button()
    {
        SceneManager.LoadScene("start scene");
    }
}
