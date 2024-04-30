using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Timer timer;
    public Text scoreText;
    public Text cumulativeScoreText;
    private int score = 0;
    private int cumulativeScore = 0; // Added variable to track cumulative score

    void Start()
    {
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString();
        cumulativeScoreText.text = "Total Score: " + GetCumulativeScore().ToString();
    }

    public void UpdateScore(int value)
    {
        score += value;
        cumulativeScore += value; // Update cumulative score
        UpdateScoreUI();
        score = 0;
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
        float tempscore = 0;
        if(elapsedTime!=0){
         //tempscore = (1000); //for presentation demo to show unlocking movement upgrades
          tempscore = (2000/elapsedTime); //calculate score based on the elapsed time
        }
        int tpscore = (int)tempscore;
        UpdateScore(tpscore);
    }
}

