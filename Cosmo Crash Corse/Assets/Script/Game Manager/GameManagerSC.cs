
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerSC : MonoBehaviour
{
    public GameObject gameOverPanel;

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
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

