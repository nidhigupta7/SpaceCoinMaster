using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void SceneLoading(string name)
    {
        SceneManager.LoadScene("GameScreen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

   
}
