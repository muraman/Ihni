using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RespawnScript : MonoBehaviour

{

    public GameObject RespawnShow ;

    void OnTriggerEnter2D (Collider2D Die) 
    {
        if (Die.tag == "Player") 
        {
            RespawnShow.SetActive(true);
        }
    }

 
    public void Restart()
    {
        string sceneName = SceneManager.GetActiveScene().name;    
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
   

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
