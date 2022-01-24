using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sCOREcONTROLLER : MonoBehaviour
{
    public int Score = 0;
    public Text Scoretext;
    public Text HighScoretext;

    private void Awake()
    {
        HighScoretext.text = "Best: " + GethighScore().ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "crystal")
        {
            Destroy(other.gameObject);
            Score++;
            Scoretext.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            if (Score> GethighScore())
            {
                PlayerPrefs.SetInt("Highscore", Score);
                HighScoretext.text = "Best: " +Score.ToString();
            }
        }
    }

    public int GethighScore()
    {
        int i = PlayerPrefs.GetInt("Highscore");
        return i;
    }
}
