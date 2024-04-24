using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Score score; // Reference to the Score script

    private float startTime;
    public bool isRunning = false;

    void Start()
    {
        timerText.enabled = false;
    }

    void Update()
    {
        if (isRunning)
        {
            float elapsedTime = Time.time - startTime;
            timerText.text = "Time: " + elapsedTime.ToString("F2");
        }
    }

    public void StartTimer()
    {
        startTime = Time.time;
        timerText.enabled = true;
        isRunning = true;
    }

    public void StopTimer()
    {

        isRunning = false;
        score.CalculateScore(); // Calculate score when the timer stops
    }

    public void resetTimer()
    {
        timerText.text = "Time: 0.00"; // Reset timer display
        isRunning = false;
    }

    public float GetElapsedTime()
    {
        float eltime = Time.time - startTime;
        return eltime;
    }
}

