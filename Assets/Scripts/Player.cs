using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
   
  
    public SpriteRenderer spriteP;
    public bool canDeath;
    public GameObject fireObject;
    public float cooldownTime = 0.08f;
    public float nextFireTime = 0f;
    public AudioSource fireAudio;
    public AudioSource deathAudio;

   IEnumerator canDamage()
    {
        yield return new WaitForSeconds(1.5f);
        canDeath = true;
        spriteP.color = new Color( 1f, 1f, 1f, 1f);
    }

   void Awake() 
   {
      if(canDeath == false)
      {
         spriteP.color = new Color( 1f, 1f, 1f, 0.39f);
         StartCoroutine("canDamage");
      }  
   }

    // Update is called once per frame
    void FixedUpdate()
    {
       PlayerMoviment();
       Fire();
    }

    private void PlayerMoviment()
    {

       //player moviment
       if(Input.GetKey("a") || Input.GetKey("left"))
       {
          transform.Translate(new Vector3(-xSpeed, 0f, 0f));
       }
       if(Input.GetKey("d") || Input.GetKey("right"))
       {
          transform.Translate(new Vector3(xSpeed, 0f, 0f));
       }

       //player limits 
        if(transform.position.x > 2.35f)
       {
          transform.position = new Vector3(2.35f, transform.position.y, 0f);
       }
        if(transform.position.x < -2.35f)
       {
          transform.position = new Vector3(-2.35f, transform.position.y, 0f);
       }
    }

    private void Fire()
    {
       if(Time.time > nextFireTime)
       {
          Instantiate(fireObject,transform.position + new Vector3(-0.28f, 0.341f, 0f), Quaternion.identity);
          Instantiate(fireObject,transform.position + new Vector3(-0.12f, 0.622f, 0f), Quaternion.identity);
          Instantiate(fireObject,transform.position + new Vector3(0.099f, 0.622f, 0f), Quaternion.identity);
          Instantiate(fireObject,transform.position + new Vector3(0.262f, 0.349f, 0f), Quaternion.identity);
          fireAudio.Play();
          nextFireTime = Time.time + cooldownTime;
       }
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("enemyfire") || col.gameObject.CompareTag("enemy"))
        {
          if(canDeath == true)
          {
            deathAudio.Play();
            Controller.scoreCount = Controller.scoreCount - 50;
            FindObjectOfType<Controller>().PlayerRespawn();
            StartCoroutine("selfDestroy");
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;   
          }       
        }
    }

    IEnumerator selfDestroy()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }

}

