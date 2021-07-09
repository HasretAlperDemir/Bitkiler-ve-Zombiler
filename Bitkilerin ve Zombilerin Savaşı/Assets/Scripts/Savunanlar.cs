using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savunanlar : MonoBehaviour {

    private ParayiTopla paraKazanma;
    public int maliyet;
    private void Start()
    {
        paraKazanma = GameObject.FindObjectOfType<ParayiTopla>();
    }

    public void ParayiArttir(int paraMiktari)
    {
        paraKazanma.ParayiEkle(paraMiktari);
        Debug.Log("Eklenen para miktarı" + paraMiktari);
    }





}
