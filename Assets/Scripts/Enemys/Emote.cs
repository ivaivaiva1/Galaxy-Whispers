using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emote : MonoBehaviour
{
    public GameObject fireEmote;
    public float cooldownTime = 4.8f;
    public float nextFireTime = 0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Fire();
    }
    private void Fire()
    {
       if(Time.time > nextFireTime)
       {
          Instantiate(fireEmote,transform.position + new Vector3( 0f, -0.9f, 0f), Quaternion.identity);
          nextFireTime = Time.time + cooldownTime;
       }
    }



}
