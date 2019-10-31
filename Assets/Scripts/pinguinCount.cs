using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pinguinCount : MonoBehaviour
{
    public int AddBanana;
    public float AddTime;
    public GameManager gm;
    public Text AddBananText;

    void Start()
    {
        AddBananText.enabled = false;
        InvokeRepeating("AddBanan", 2, AddTime);
        gm = GameObject.Find("MainGame").GetComponent<GameManager>();

       
    }

  
    void textB()
    {
      AddBananText.enabled = false;
    }
    void AddBanan()
    {
        gm.GetComponent<GameManager>().AddScoreBanana(AddBanana);
        transform.Rotate(Vector3.forward * 90f);
        AddBananText.enabled = true;
        AddBananText.text = "+ " + AddBanana + "!";
        Invoke("textB", 2);

    }
   


}
