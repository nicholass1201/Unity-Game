using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Timer timer;
    public Text scoreText;
    public Text cumulativeScoreText;
    private float score = 0;
    private float cumulativeScore = 0; // Added variable to track cumulative score

    void Start()
    {
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString();
        cumulativeScoreText.text = "Cumulative Score: " + GetCumulativeScore().ToString();
    }

    public void UpdateScore(float value)
    {
        score += value;
        cumulativeScore += value; // Update cumulative score
        UpdateScoreUI();
    }

    public float GetScore()
    {
        return score;
    }

    public float GetCumulativeScore()
    {
        return cumulativeScore; // Return cumulative score
    }

     public void CalculateScore()
    {
        float elapsedTime = timer.GetElapsedTime(); // Get the elapsed time from the timer
        float tempscore = Mathf.Max(0, 1000 - elapsedTime); // Adjust the scoring mechanism as per your requirement
        UpdateScore(tempscore);
    }
}

