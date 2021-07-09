using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavunanObjeleriOlustur : MonoBehaviour {

	public Camera bizimKameramiz;

	private GameObject savunanObjelerParent;
	private ParayiTopla toplamPara;

	private void Start()
	{
		toplamPara = GameObject.FindObjectOfType<ParayiTopla>();
		savunanObjelerParent = GameObject.Find("Savunanlar");

		if (!savunanObjelerParent)
		{
			savunanObjelerParent = new GameObject("Savunanlar");
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
    {
        Vector2 gercekDunyaPozisyonu = farePozisyonunuGercekDunyayaAktar();
        Vector2 gercekDunyaPozisyonunuYuvarlama = pozisyonuYuvarla(gercekDunyaPozisyonu);
        GameObject olusacakSavunanObje = PanelElemanKontrol.seciliEleman;

		int savunanObjeninMaliyeti = olusacakSavunanObje.GetComponent<Savunanlar>().maliyet;

		if(toplamPara.ParayiKullan(savunanObjeninMaliyeti) == ParayiTopla.ObjeOlusturmaDurumu.BASARILI)
        {
			ObjeyiOlustur(olusacakSavunanObje, gercekDunyaPozisyonunuYuvarlama);
		}
        else
        {
			Debug.Log("Bakiyeniz yetersiz.");
        }
		

    }

    private void ObjeyiOlustur(GameObject olusacakObjemiz, Vector2 gercekDunyaPozisyonunuYuvarlamamiz)
    {
        GameObject yeniSavunanObje = Instantiate(PanelElemanKontrol.seciliEleman, gercekDunyaPozisyonunuYuvarlamamiz,Quaternion.identity) as GameObject;
        yeniSavunanObje.transform.parent = savunanObjelerParent.transform;
    }

    Vector2 pozisyonuYuvarla(Vector2 yuvarlanacakPosizyon)
    {
		float yuvarlaX = Mathf.CeilToInt(yuvarlanacakPosizyon.x);
		float yuvarlaY = Mathf.CeilToInt(yuvarlanacakPosizyon.y);
		return new Vector2(yuvarlaX, yuvarlaY);
    }
	Vector2 farePozisyonunuGercekDunyayaAktar()
    {
		float fareX = Input.mousePosition.x;
		float fareY = Input.mousePosition.y;
		float kameraUzakligi = 15f;

		Vector3 mousePozisyonu = new Vector3(fareX, fareY, kameraUzakligi);
		Vector2 gercekDunyadakiPozisyonu = bizimKameramiz.ScreenToWorldPoint(mousePozisyonu);


		return gercekDunyadakiPozisyonu;
	}


}
