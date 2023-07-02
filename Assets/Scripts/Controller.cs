using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    
    public GameObject player;
    public static int scoreCount;

    public Text scoreText;
    public Text scoreMenu;
    public Text scoreFinal;
    public Text Patente;
    
    public AudioSource gameA;
    public AudioSource boosA;
    public AudioSource fimA;
    
    public void BossAudio()
    {
       gameA.Stop(); 
       boosA.Play();
    }
 
    public void fimAudio()
    {
       boosA.Stop(); 
       fimA.Play();
    }




    public void NovaPatente()
    {
       if(scoreCount >= 2425)
       {
          Patente.text = "Almirante";
       } else
       if(scoreCount >= 1940)
       {
          Patente.text = "Capitão";
       } else
       if(scoreCount >= 1455)
       {
          Patente.text = "Tenente";
       } else
       if(scoreCount >= 970)
       {
          Patente.text = "Sargento";
       } else
       {
          Patente.text = "Recruta";
       }
       
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreCount = 0;
    }

    void Update()
    {
        scoreText.text = scoreCount.ToString();  
        scoreMenu.text = "Score: " + scoreCount.ToString();  
        scoreFinal.text = "Score: " + scoreCount.ToString();  
    }

    public void PlayerRespawn()
    {
        StartCoroutine("ressurect");
    }

    IEnumerator ressurect()
    {
        yield return new WaitForSeconds(3f);
        Instantiate(player);
    }
}
