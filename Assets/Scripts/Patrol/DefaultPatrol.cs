using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultPatrol : MonoBehaviour
{
    
    public Transform[] points;
    int current;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        current = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speedChange();

        if(transform.position.y < -7f)
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

    void speedChange()
    {
        if(current > 9)
        {
           speed = 1.5f;
        }
        else if(current > 4)
        {
           speed = 1.1f;
        }
        else if(current > 1)
        {
           speed = 0.7f;
        }
    }

}
 