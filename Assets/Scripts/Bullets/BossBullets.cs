using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullets : MonoBehaviour
{

    public float speedX = 0f;
    public float speedY;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartBattle");
    }

    IEnumerator StartBattle()
    {
        yield return new WaitForSeconds(7f);
        speedY = 0.04f;
    }
    
   

    void FixedUpdate()
    {
        transform.Translate(new Vector3(speedX, speedY, 0f)); 
            
        if(transform.position.y > 11)
        {
           Destroy(this.gameObject);
        }
    } 
}
