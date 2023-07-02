using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCount : MonoBehaviour
{
 
    private float startTime;
    public float actualTime;
    public GameObject Wave1;
    public GameObject WaveDisco;
    public GameObject WaveAngry;
    public GameObject WaveNyan;
    public GameObject WaveSmile;
    public GameObject WaveBrush;
    public GameObject WaveEvil;
    public GameObject CaveiraL;
    public GameObject CaveiraR;
    public GameObject BigR1;
    public GameObject BigR2;
    public GameObject BigR3;
    public GameObject BigL1;
    public GameObject BigL2;
    public GameObject BigL3;
    public GameObject doomL;
    public GameObject doomR;
    public GameObject waveFinal;
    public GameObject Boss;
    public static int doomAlive = 2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnsController");  
    }

    IEnumerator SpawnsController()
    {
        yield return new WaitForSeconds(5f);
        Instantiate(Wave1);
        yield return new WaitForSeconds(17f);
        Instantiate(WaveDisco);
        yield return new WaitForSeconds(17f);
        Instantiate(WaveAngry);
        Instantiate(WaveBrush);
        Instantiate(WaveSmile);
        Instantiate(WaveEvil);
        Instantiate(WaveNyan);
        yield return new WaitForSeconds(46f);
        Instantiate(CaveiraL);
        Instantiate(CaveiraR);
        yield return new WaitForSeconds(10f);
        Instantiate(BigR1);
        Instantiate(BigR2);
        Instantiate(BigR3);
        Instantiate(BigL1);
        Instantiate(BigL2);
        Instantiate(BigL3);
        yield return new WaitForSeconds(47f);
        Instantiate(WaveDisco);
        yield return new WaitForSeconds(6f);
        Instantiate(waveFinal);
        Instantiate(doomL);
        Instantiate(doomR);
        yield return new WaitForSeconds(62f);
        FindObjectOfType<Controller>().BossAudio();
        Instantiate(Boss);
    }

    
    // Update is called once per frame
//     void FixedUpdate()
//     {
//         actualTime = Time.time - startTime;
//         //First Wave
//         if(actualTime == 5f)
//         {
//              Instantiate(Wave1);
//         }
//         if(actualTime == 22f)
//         {
//              Instantiate(WaveDisco);
//         }
//         //Emoticons 39f
//         if(actualTime == 39f)
//         {
//             Instantiate(WaveAngry);
//             Instantiate(WaveBrush);
//             Instantiate(WaveSmile);
//             Instantiate(WaveEvil);
//             Instantiate(WaveNyan);
//         }
//         if(actualTime == 85f)
//         {
//             //134 pra matar
//             Instantiate(CaveiraL);
//             Instantiate(CaveiraR);
//         }
//         if(actualTime == 95f)
//         { 
//             Instantiate(BigR1);
//             Instantiate(BigR2);
//             Instantiate(BigR3);
//             Instantiate(BigL1);
//             Instantiate(BigL2);
//             Instantiate(BigL3);
//         }
//          if(actualTime == 142f)
//         {
//              Instantiate(WaveDisco);
//         }
//         if(actualTime == 148f)
//           { 
//             //148
//             Instantiate(waveFinal);
//             Instantiate(doomL);
//             Instantiate(doomR);
//           }
//         if(actualTime >= 210 && doomAlive == 0)
//           {         
//             Instantiate(Boss);
//           }
//     }
 }
