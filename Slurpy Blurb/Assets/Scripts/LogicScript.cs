using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject pauseMenu;
    public AudioSource scoreGainSound;
    private bool isGameOverScreenDisplayed = false;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Press 'Escape' to toggle pause
        {
            if (!isPaused)
            {
                pause();
            }
            else
            {
                unPause();
            }
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        scoreGainSound.Play();
    }

    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        isGameOverScreenDisplayed = true;
    }

    public void pause()
    {
        Time.timeScale = 0f;
        isPaused = true;

        Debug.Log("Paused the game");
        
        if(gameOverScreen.activeSelf)
        {
            gameOverScreen.SetActive(false);
        }
        
        pauseMenu.SetActive(true);
    }

    public void unPause()
    {
        Time.timeScale = 1f;

        Debug.Log("Game is unpaused");

        if(isGameOverScreenDisplayed)
        {
            gameOverScreen.SetActive(true);
        }
        
        isPaused = false;
        pauseMenu.SetActive(false);
    }

    public void goToMainMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");  
    }
}
