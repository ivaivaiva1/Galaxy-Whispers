using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isEnemies : MonoBehaviour
{

    public SpriteRenderer sprite;
    public int score;
    public int life;
    public int number = 0;

    void Update()
    {
        if(life <= 0 && number == 0)
        {
           Controller.scoreCount = Controller.scoreCount + score;
           Destroy(this.gameObject);
        }
        else if(life <= 0 && number == 1)
        {
           Controller.scoreCount = Controller.scoreCount + score;
           TimeCount.doomAlive = TimeCount.doomAlive - 1;
           Destroy(this.gameObject);
        }
        else if(life <= 0 && number == 2)
        {
           //boss
           Controller.scoreCount = Controller.scoreCount + score;
           FindObjectOfType<Controller>().fimAudio();
           FindObjectOfType<Controller>().NovaPatente();
           FindObjectOfType<FinalMenu>().EndGame();
           Destroy(this.gameObject);
        }
        else if(life <= 0 && number == 3)
        {
           Controller.scoreCount = Controller.scoreCount + score;
           Boss.PillarsAlive = Boss.PillarsAlive - 1;
           Destroy(this.gameObject);
        }
    }
   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("PlayerFire"))
        {
           if(number == 2 && Boss.PillarsAlive == 0)
           {
             sprite.color = Color.red;
             StartCoroutine("flashred");
             life = life -1;
           } else
           if(number == 1 || number == 0 || number == 3)
           {
             sprite.color = Color.red;
             StartCoroutine("flashred");
             life = life -1;   
           }             
        }
        if (col.gameObject.CompareTag("Player"))
        {
           sprite.color = Color.red;
           StartCoroutine("flashred");
           life = life -20;
        }
    }

     IEnumerator flashred()
    {
        yield return new WaitForSeconds(0.2f);
        sprite.color = Color.white;
    }

}
