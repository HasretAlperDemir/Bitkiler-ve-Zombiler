using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParayiTopla : MonoBehaviour
{
    public int toplamPara = 0;
    private Text paraMiktarininGosterimi;
    public enum ObjeOlusturmaDurumu {BASARILI,BASARISIZ };

    private void Start()
    {
        //toplamPara = 120;
        //paraMiktarininGosterimi.text = toplamPara.ToString();

        paraMiktarininGosterimi = GetComponent<Text>();
        parayiEkrandaGoster();
    }

    public void ParayiEkle(int paraMiktari)
    {
        toplamPara += paraMiktari;
        parayiEkrandaGoster();
    }

    public ObjeOlusturmaDurumu ParayiKullan(int savunanObjeninMaliyeti)
    {
        if(toplamPara>= savunanObjeninMaliyeti)
        {

            toplamPara -= savunanObjeninMaliyeti;
            parayiEkrandaGoster();
            
            return ObjeOlusturmaDurumu.BASARILI; 
        }
        else
        {
            return ObjeOlusturmaDurumu.BASARISIZ;
        }
    }




    public void parayiEkrandaGoster()
    {
        paraMiktarininGosterimi.text = toplamPara.ToString();
        
    }



}

