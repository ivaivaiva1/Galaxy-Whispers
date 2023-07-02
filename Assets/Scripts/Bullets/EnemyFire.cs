using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
   
    public float speedX = 0f;
    public float speed;
     
    void FixedUpdate()
    {
        transform.Translate(new Vector3(speedX, speed, 0f)); 
            
        if(transform.position.x < -2.535f || transform.position.x > 2.535f || transform.position.y < -5.3f || transform.position.y > 5.3f)
        {
           Destroy(this.gameObject);
        }
    } 
}
