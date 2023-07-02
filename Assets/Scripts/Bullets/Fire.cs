using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    void FixedUpdate()
    {
        transform.Translate(new Vector3(0f, 0.3f, 0f)); 
            
        if(transform.position.y > 5.07f)
        {
           Destroy(this.gameObject);
        }
    } 
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("enemy"))
        {
           Destroy(this.gameObject);
        }
    }
        
    
}
