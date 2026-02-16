using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundCounter : MonoBehaviour
{

    [Header("Dynamic")]
    public int round = 1;
    public int maxRounds = 4;

    private Text uiText;

    void Start()
    {
        uiText = GetComponent<Text>();
        UpdateText();
    }

    public void UpdateText()
    {
        uiText.text = "Round " + round;
    }

    public void GameOver()
    {
        uiText.text = "Game Over";
        Time.timeScale = 0f;
    }
}

