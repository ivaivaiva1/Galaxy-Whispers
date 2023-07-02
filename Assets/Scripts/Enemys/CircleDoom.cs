using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDoom : MonoBehaviour
{

    public float cooldownTime;
    public float nextFireTime = 0f;

    public GameObject doomBullets;
    public Transform FindPlayer;

    void FixedUpdate()
    {
        
        Fire();
    }

    private void Fire()
    {
       if(Time.time > nextFireTime && transform.position.y > -0.8f)
       { 
         FindPlayer = GameObject.FindGameObjectWithTag("Player").transform;
         if(FindPlayer != null)
         {
            Instantiate(doomBullets,transform.position, Quaternion.identity);
            nextFireTime = Time.time + cooldownTime; 
         } 
       }
    }
}
