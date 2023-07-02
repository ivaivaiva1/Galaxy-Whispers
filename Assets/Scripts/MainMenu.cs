using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
   public GameObject CreditsPanel;

   public void PlayGame()
   {
      SceneManager.LoadScene("GameScene");
   }

   public void Credits()
    {
       CreditsPanel.SetActive(true);
    } 

  public void Voltar()
   {
       CreditsPanel.SetActive(false);
   } 
   
}
