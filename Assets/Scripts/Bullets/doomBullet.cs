using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doomBullet : MonoBehaviour
{

    public float speed;
    private Transform FindPlayer;
    private Vector2 target;






    // Start is called before the first frame update
    void Start()
    {
        FindPlayer = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(FindPlayer.position.x, FindPlayer.position.y);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
          Destroy(this.gameObject);
        }
    }
}
