using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{

    private int score;
    public Text scoreText;

    // Use this for initialization
    void Start()
    {
        
      
    }



    // Update is called once per frame
    void Update()
    {


    }
    

        public void IsScored()
        {
            score = score + 1;
        SetScoreText();
  
        
    }

    public void wipeScore()
    {
        score = 0;
        print("wiped score!");
        SetScoreText();
    }

    void SetScoreText()
    {

        scoreText.text = "score: " + score.ToString();

    }


}
