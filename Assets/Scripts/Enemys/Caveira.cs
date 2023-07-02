using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caveira : MonoBehaviour
{
    public GameObject fireC;
    public GameObject fireCL;
    public GameObject fireCR;
    public float cooldownTime = 4f;
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
          Instantiate(fireCL,transform.position + new Vector3( -0.852f, -1.413f, 0f), Quaternion.identity);
          Instantiate(fireC,transform.position + new Vector3( -0.153f, -1.788f, 0f), Quaternion.identity);
          Instantiate(fireC,transform.position + new Vector3( 0.153f, -1.788f, 0f), Quaternion.identity);
          Instantiate(fireCR,transform.position + new Vector3( 0.843f, -1.411f, 0f), Quaternion.identity);
          StartCoroutine("fire2");
          nextFireTime = Time.time + cooldownTime;
       }
    }

    IEnumerator fire2()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(fireCL,transform.position + new Vector3( -0.852f, -1.413f, 0f), Quaternion.identity);
        Instantiate(fireC,transform.position + new Vector3( -0.153f, -1.788f, 0f), Quaternion.identity);
          Instantiate(fireC,transform.position + new Vector3( 0.153f, -1.788f, 0f), Quaternion.identity);
        Instantiate(fireCR,transform.position + new Vector3( 0.843f, -1.411f, 0f), Quaternion.identity);
    }

}
