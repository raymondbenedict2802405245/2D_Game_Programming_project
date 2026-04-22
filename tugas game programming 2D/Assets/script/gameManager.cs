using UnityEngine;
using TMPro;
using System.Drawing;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        instance = this;
    }

    public void addScore(int points)
    {
        score += points;
        scoreText.text = "score = " + score;

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
