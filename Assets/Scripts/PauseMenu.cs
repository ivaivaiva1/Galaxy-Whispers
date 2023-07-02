using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   
   public static bool GameIsPaused = false; 
   public GameObject pauseMenuUI;
   

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused == true)
            {
                Resume();
            } else
            {
                Pause();
            }     
        }
    }

    public void Resume()
    {
       pauseMenuUI.SetActive(false);
       Time.timeScale = 1f;
       GameIsPaused = false;
    }

    public void Pause()
    {
       pauseMenuUI.SetActive(true);
       Time.timeScale = 0f;
       GameIsPaused = true;
    }

     public void callMenu()
   {
      Resume();
      SceneManager.LoadScene("Menu");
   }
   
   public void PlayGame()
   {
      SceneManager.LoadScene("GameScene");
   }


}
