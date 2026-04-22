using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel; 

    bool isPaused = false;

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pausePanel.SetActive(true);   
        Time.timeScale = 0f;          
        isPaused = true;
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false); 
        Time.timeScale = 1f;         
        isPaused = false;
    }

    public void QuitGame()
    {
        
        Application.Quit();
        Debug.Log("thanks for playing our game");
    }
}
