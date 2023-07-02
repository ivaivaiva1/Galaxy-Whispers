using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
   
    public int Min;
    public int Max;
    public GameObject fire1;
    public float cooldownTime;
    public float nextFireTime = 10f;

    void Awake() {
        cooldownTime = Random.Range(Min,Max);
    }



    // Update is called once per frame
    void FixedUpdate()
    {    
        Fire(); 
    }
    private void Fire()
    {
       if(Time.time > nextFireTime)
       {
          //6,15
          cooldownTime = Random.Range(Min,Max);
          Instantiate(fire1,transform.position + new Vector3( 0f, -0.353f, 0f), Quaternion.identity);
          nextFireTime = Time.time + cooldownTime;
       }
    }
}
