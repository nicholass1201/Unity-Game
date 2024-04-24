using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool isRunning = false;

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
        timerText.enabled = false;
        isRunning = false;
    }

    public void ResetTimer()
    {
        timerText.text = "Time: 0.00"; // Reset timer display
        isRunning = false;
    }

    public float GetElapsedTime()
    {
        if (!isRunning)
            return 0;

        return Time.time - startTime;
    }
}