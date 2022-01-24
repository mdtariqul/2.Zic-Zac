using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
    public Text GScoretext;
    void Awake()
    {
        int i = PlayerPrefs.GetInt("Score");
        GScoretext.text = "Your Score: "+i.ToString();
    }
}
