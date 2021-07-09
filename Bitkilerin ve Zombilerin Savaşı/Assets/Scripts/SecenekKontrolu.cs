using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecenekKontrolu : MonoBehaviour {

	public Slider sesAyari;
	public Slider zorlukAyari;
	public sahneKontrolu sahneYoneticisi;
	private muzikKontrolu muzikYoneticisi;



	// Use this for initialization
	void Start () {
		sesAyari.value = OyuncuAyarlari.AnaSesiAl();
		zorlukAyari.value = OyuncuAyarlari.zorluguAl();
		muzikYoneticisi = GameObject.FindObjectOfType<muzikKontrolu>();
	}
	
	// Update is called once per frame
	void Update () {
		muzikYoneticisi.SesiAyarla(sesAyari.value);
	}

	public void SesiKaydetveCik()
    {
		OyuncuAyarlari.AnaSesiAyarla(sesAyari.value);
		OyuncuAyarlari.zorluguAyarla(zorlukAyari.value);
		sahneYoneticisi.IsimleSahneCagirma("1.Menu");
		
    }
	public void BaslangicAyarlariniUygula()
    {
		sesAyari.value = 0.5f;
		zorlukAyari.value = 2f;
    }




}
