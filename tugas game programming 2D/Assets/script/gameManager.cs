using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;

    private int score = 0;
    private int bestScore = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        UpdateUI();
    }

    public void addScore(int points)
    {
        score += points;

        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("BestScore", bestScore);
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        if (scoreText != null) scoreText.text = "Score = " + score;
        if (bestScoreText != null) bestScoreText.text = "Best = " + bestScore;
    }

    public void RestartGame()
{
    UnityEngine.SceneManagement.SceneManager.LoadScene(
        UnityEngine.SceneManagement.SceneManager.GetActiveScene().name
    );
}

}
