using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;

    public GameObject[] pinguins;
    public float minPinguinX, maxPinguinX, minPinguinY, maxPinguinY;



    public int  PinguinCount;
    public int BananaPrice, PinguinPrice;
    public float BananaBalance;
    public Text BananaBalanceText, BananaSecText, BananaPriceText, PinguinPriceText;
    public Text PinguinCountText, BananaCountText;
    public float Click;
    public float BananaCount;
    public GameObject hourse;
    public Text HourseText;

    public float result;


    // Start is called before the first frame update
    void Start()
    {
        HourseText.enabled = false;
        //StartCoroutine(BonusPerSec());
        Click = 0;
      //  InvokeRepeating("ResetCklick", 1, 1);
    }

    public void ResetCklick()
    {
        Click = BananaCount;
        BananaSecText.GetComponent<Text>().text = BananaCount.ToString();
    }
   

    void textB()
    {
        HourseText.enabled = false;
        Click = 0;
    }

    void AddTextHousre()
    {
        HourseText.enabled = true;
        HourseText.text = "+ " + BananaCount + "!";

        Click += BananaCount;
        BananaSecText.GetComponent<Text>().text = BananaCount.ToString();
        Invoke("textB", 1);
    }

    // Update is called once per frame
    void Update()
    {
        result = (float)System.Math.Round(BananaBalance,0);

        BananaBalanceText.text = result.ToString();
        BananaSecText.text = Click.ToString();
        BananaPriceText.text = BananaPrice.ToString();
        PinguinPriceText.text = PinguinPrice.ToString();
        PinguinCountText.text = PinguinCount.ToString();
        BananaCountText.text = BananaCount.ToString();
    }

    public void OnClick()
    {
        
       hourse.transform.Rotate(Vector3.forward * -90f);

        AddScoreBanana(BananaCount);
        Invoke("AddTextHousre", 0);
    }


    public void OnClickBananaBtn()
    {
        if (BananaBalance > BananaPrice)
        {
            BananaBalance -= BananaPrice;
            BananaCount *= 1.1f;
            BananaCount = (float)System.Math.Round(BananaCount, 0);
        }
    }

    public void AddScoreBanana(float scoreAdd)
    {
        BananaBalance += scoreAdd;
    }

    public void OnCklickPinguin()
    {
        if (BananaBalance > PinguinPrice)
        {
            BananaBalance -= PinguinPrice;
            GameObject pinguin = pinguins[Random.Range(0, pinguins.Length)];
            Vector2 pos = new Vector3(Random.Range(minPinguinX, maxPinguinX), Random.Range(minPinguinY, maxPinguinY), 0);


            GameObject s = Instantiate(pinguin, pos, Quaternion.identity) as GameObject;
            s.transform.SetParent(canvas.transform, false);
            PinguinCount++;
        }
    }


}
