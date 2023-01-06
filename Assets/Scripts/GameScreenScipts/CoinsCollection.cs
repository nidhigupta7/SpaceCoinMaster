using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CoinsCollection : MonoBehaviour
{
    public TextMeshProUGUI score;
    private int scoreValue;

    public void Start()
    {
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            collision.gameObject.SetActive(false);
            scoreValue += 1;
            SetCoinScoreText();
            setScore();
        }
        
    }
    void SetCoinScoreText()
    {
        if (PlayerPrefs.GetInt("highestscoreever", 0) < scoreValue)
            PlayerPrefs.SetInt("highestscoreever", scoreValue);
    }

    private void setScore()
    {
        score.text = "Score:" + scoreValue;
         PlayerPrefs.SetInt("TotalScore", scoreValue);
    }

}
