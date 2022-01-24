using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class ExitButton : MonoBehaviour
{
   
    public void quitGame()
    {
        
        //Thread.Sleep(1200);
        Application.Quit();
    }
}
