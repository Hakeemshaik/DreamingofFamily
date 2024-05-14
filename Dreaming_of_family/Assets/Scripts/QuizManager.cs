using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject objectToHide;
    public GameObject objectToUnhide;
    public int pointsToAdd = 10;
    public Text scoreText;

    private int score = 0;

    void Start()
    {
        // Initialize score text
        if (scoreText == null)
        {
            Debug.LogError("Please assign the scoreText variable in the Unity Editor!");
        }
        else
        {
            UpdateScoreText();
        }
    }

    public void ButtonClickedWithPoints()
    {
        // Hide objectToHide
        objectToHide.SetActive(false);

        // Unhide objectToUnhide
        objectToUnhide.SetActive(true);

        // Add points
        score += pointsToAdd;
        UpdateScoreText();
    }

    public void ButtonClickedWithoutPoints()
    {
        // Hide objectToHide
        objectToHide.SetActive(false);

        // Unhide objectToUnhide
        objectToUnhide.SetActive(true);

        // Don't add points
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
        else
        {
            Debug.LogError("scoreText variable is not assigned!");
        }
    }
}