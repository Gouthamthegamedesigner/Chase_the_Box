using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    private float elapsedTime;
    private float highScore;

    private void Start()
    {
        // Load the high score from PlayerPrefs
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
        UpdateHighScoreUI();
    }

    private void Update()
    {
        // Update elapsed time
        elapsedTime += Time.deltaTime;

        // Convert elapsed time to minutes and seconds
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);

        // Update the timer UI
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        // Check if elapsed time is a new high score
        if (elapsedTime > highScore)
        {
            highScore = elapsedTime;
            PlayerPrefs.SetFloat("HighScore", highScore); // Save the new high score
            UpdateHighScoreUI();
        }
    }

    private void UpdateHighScoreUI()
    {
        // Convert high score to minutes and seconds
        int highScoreMinutes = Mathf.FloorToInt(highScore / 60);
        int highScoreSeconds = Mathf.FloorToInt(highScore % 60);

        // Update the high score UI
        highScoreText.text = string.Format("{0:00}:{1:00}", highScoreMinutes, highScoreSeconds);
    }
}
