using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Debug.Log("Yep, it works");
    }

}
