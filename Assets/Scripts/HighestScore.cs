using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighestScore : MonoBehaviour
{
    public TextMeshProUGUI totalscoretext;
    public TextMeshProUGUI highscoretext;

    // Start is called before the first frame update
    void Start()
    {
        highscoretext.text = "Your Highest Score is : " + PlayerPrefs.GetInt("highestscoreever", 0);
        totalscoretext.text = "Your Score is : " + PlayerPrefs.GetInt("TotalScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
