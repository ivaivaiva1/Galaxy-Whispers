using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPatrol : MonoBehaviour
{
    
    public Transform[] points;
    int current;
    public float speed;
    public bool finishTime = false;
    public float saidaSpeed;
    public int saidaTime;
    public int destroyTime;


    // Start is called before the first frame update
    void Start()
    {
        current = 0;
        StartCoroutine("selfDestroy");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if(finishTime == true)
        //{
            //transform.Translate(new Vector3(-2f, 0f, 0f));
        //}
        //else 
        if(current == 2)
        {
            StartCoroutine("canWalk");
        }  
        else if(transform.position != points[current].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
        }
        else 
            current=(current+1) % points.Length;
    }
    
    IEnumerator canWalk()
    {
        yield return new WaitForSeconds(saidaTime);
        transform.Translate(new Vector3(saidaSpeed, 0f, 0f));
    }
    IEnumerator selfDestroy()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(this.gameObject);
    }
}

