using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float startTime = 60f;
    private float timer;

    public TMP_Text timerText;

    void Start()
    {
        timer = startTime;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

            // Convert 60→0 seconds to 1→0 normalized value
            float normalized = timer / startTime;
            timerText.text = timer.ToString("F0");

            Debug.Log("Timer: " + timer.ToString("F2") + " | Normalized: " + normalized.ToString("F2"));
        }
        else
        {
            timer = 0;
            Debug.Log("Time’s up! Normalized: 0");
        }
    }
}