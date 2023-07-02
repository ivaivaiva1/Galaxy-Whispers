using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoPatrol : MonoBehaviour
{
    
    public int enemiesNumber;
    public Transform[] points;
    int current;
    public float speed;

    
    void Start()
    {
        current = 0;
    }

    void FixedUpdate()
    {   
        if(transform.position.x > 3f && enemiesNumber == 0)
        {
           Destroy(this.gameObject);
        } 
        else if(transform.position.y < -6f && enemiesNumber == 1)
        {
           Destroy(this.gameObject);
        } 
    
         if(transform.position != points[current].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
        }
        else 
            current=(current+1) % points.Length;
    }
}
