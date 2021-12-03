using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : ScriptableObject
{
   //Guided by Gamesplusjames video, "Unity Endless Runner Tutorial #12 - Score & High Score System" on youtube
   public Text scoreText;
   public Text highScoreText;

   public float scoreCount;
   public float highScoreCount;

   public float pointsPerSecond;
   public bool scoreIncreasing = true;

   private void Start()
   {
      SetValue(0);
      FindObjectOfType<GameManagerSC>().IncreaseSpawnSpeed();
      if (PlayerPrefs.HasKey("HighScore"))
      {
         highScoreCount = PlayerPrefs.GetFloat("HighScore");
      }
   }

   public void SetValue(float amount)
   {
      highScoreCount = 0;
   }

   private void Update()
   {
      if (scoreIncreasing)
      {
         scoreCount += pointsPerSecond * Time.deltaTime;
      }

      if (scoreCount >= highScoreCount)
      {
         highScoreCount = scoreCount;
         PlayerPrefs.SetFloat("HighScore", highScoreCount);
      }
      
      scoreText.text = "Score: " + Mathf.Round (scoreCount);
      highScoreText.text = "High Score: " + Mathf.Round (highScoreCount);
   }
}

