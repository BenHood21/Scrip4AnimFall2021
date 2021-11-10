
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerSC : MonoBehaviour
{
    public GameObject gameOverPanel;

    public int riseSpeed = 1;
    public int scoreThreshold = 5;
    
    private ScoreManager theScoreManager;

    private void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }
    
    public void Restart()
    {
        theScoreManager.scoreIncreasing = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        AmmoTextScript.ammoAmount = 0;
        
    }

    public void QuitGame()
    {
        AmmoTextScript.ammoAmount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void IncreaseSpawnSpeed()
    {
        if (FindObjectOfType<ScoreManager>().scoreCount >= scoreThreshold)
        {
            riseSpeed++; //riseSpeed = riseSpeed +1;
            scoreThreshold *= 2; //scoreThreshold = scoreThreshold * 2;
        }
    }
}

