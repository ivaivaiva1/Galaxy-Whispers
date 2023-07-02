using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMenu : MonoBehaviour
{
    public GameObject FinalMenuUI;

    public void EndGame()
    {
       StartCoroutine("FinalPanel");
    }
   
    IEnumerator FinalPanel()
    {
        yield return new WaitForSeconds(2f);
        FinalMenuUI.SetActive(true);
    }
    

    
}
