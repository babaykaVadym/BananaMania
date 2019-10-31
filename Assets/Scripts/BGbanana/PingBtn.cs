using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingBtn : MonoBehaviour
{

    public GameObject canvas;

    public GameObject[] pinguinsGold;
    public float minLeftX, maxLeftX;
    public float minRightX, maxRightX;
    public float minY, maxY;
    private int bok;
    public float timeGeneratorMin, timeGeneratorMax, times;

    private void Start()
    {
        StartCoroutine(GeneratorPinguin());
    }
   
    private void OnKilick()
    {
        StartCoroutine(GeneratorPinguin());
    }


  IEnumerator GeneratorPinguin()
    {
        yield return new WaitForSeconds(times);
        GameObject pinguin = pinguinsGold[Random.Range(0, pinguinsGold.Length)];
        times = Random.Range(timeGeneratorMin, timeGeneratorMax);
        bok = Random.Range(1,3);
        if(bok == 1)
        {
            Vector2 pos = new Vector2(Random.Range(minLeftX, maxLeftX), Random.Range(minY, maxY));
            GameObject s = Instantiate(pinguin, pos, Quaternion.identity) as GameObject;
            s.transform.SetParent(canvas.transform, false);
        }
        else
        {
            Vector2 pos = new Vector2(Random.Range(minRightX, maxRightX), Random.Range(minY, maxY));
            GameObject s = Instantiate(pinguin, pos, Quaternion.identity) as GameObject;
            s.transform.SetParent(canvas.transform, false);


        }

       
            }
    
    
}
