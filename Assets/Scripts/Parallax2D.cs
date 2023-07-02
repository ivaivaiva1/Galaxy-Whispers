using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax2D : MonoBehaviour
{
    
    public float scrollSpeed;

    public float endY;
    public float startY;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * scrollSpeed * Time.deltaTime);
        if(transform.position.y <= endY)
        {
            Vector2 pos = new Vector2(transform.position.x , startY);
            transform.position = pos;
        }
    }
}
