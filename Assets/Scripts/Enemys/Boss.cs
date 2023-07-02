using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    
    public static int PillarsAlive;
    public GameObject Pillar1;
    public GameObject Pillar2;
    public GameObject BossWave1;
    public GameObject BossWave2;
    public GameObject BossWave3;
    public GameObject Rajada1;
    public GameObject Rajada2;

    public int rajadaNum = 0;
    public int actualWave = 1;


    void Start() 
    {
        StartCoroutine("StartBattle");
    }
    
    private void FixedUpdate() 
    {
        print(PillarsAlive);
    }

    IEnumerator StartBattle()
    {
        yield return new WaitForSeconds(10f);
        Instantiate(Pillar1);
        Instantiate(Pillar2);      
        PillarsAlive = 2;
        StartCoroutine("RespawnPillar");
        yield return new WaitForSeconds(1f);
        StartCoroutine("ScoreDrain");
        StartCoroutine("AttackSequence");
    }
     IEnumerator ScoreDrain()
    {
        yield return new WaitForSeconds(1f);
        Controller.scoreCount = Controller.scoreCount - 5;
        StartCoroutine("ScoreDrain");
    }
  
    IEnumerator AttackSequence()
    {
        yield return new WaitForSeconds(3f);
        rajadaNum = 0;
        StartCoroutine("Rajada1Timer");
        yield return new WaitForSeconds(10f);
        StartCoroutine("BulletWaves");
        yield return new WaitForSeconds(30f);
        StartCoroutine("AttackSequence");
    }

    IEnumerator Rajada1Timer()
    {
        yield return new WaitForSeconds(0.5f);
        if(rajadaNum < 12)
        {
          Instantiate(Rajada1,transform.position + new Vector3(0f, 0f, 0f), Quaternion.identity);
          rajadaNum = rajadaNum + 1;
          StartCoroutine("Rajada2Timer");
        }   
    }

    IEnumerator Rajada2Timer()
    {
        yield return new WaitForSeconds(0.5f);
        if(rajadaNum < 12)
        {
          //Instantiate(Rajada2,transform.position + new Vector3(0.65f, -0.73f, 0f), Quaternion.identity);
          Instantiate(Rajada1,transform.position + new Vector3(0f, 0f, 0f), Quaternion.identity);
          rajadaNum = rajadaNum + 1;
          StartCoroutine("Rajada1Timer");    
        }
    }
  
     IEnumerator BulletWaves()
    {
        yield return new WaitForSeconds(3f);
        if(actualWave > 3)
        {
           actualWave = 1;
        }
        if(actualWave == 1)
        {
           Instantiate(BossWave1);
           actualWave = actualWave + 1;
        } else
        if(actualWave == 2)
        {
           Instantiate(BossWave2);
           actualWave = actualWave + 1;
        } else
        if(actualWave == 3)
        {
           Instantiate(BossWave3);
           actualWave = actualWave + 1;
        }
    }
    
    IEnumerator RespawnPillar()
    {
        yield return new WaitForSeconds(30f);
        if(PillarsAlive == 0)
        {
          Instantiate(Pillar1);
          Instantiate(Pillar2);
          PillarsAlive = 2;
          StartCoroutine("RespawnPillar");
        }else   
        StartCoroutine("RespawnPillar");
    }   
}
