using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullets2 : MonoBehaviour
{
    public float speedX = 0f;
    public float speed;
     
    void FixedUpdate()
    {
        transform.Translate(new Vector3(speedX, speed, 0f)); 
            
        if(transform.position.y < -6)
        {
           Destroy(this.gameObject);
        }
    } 
}

