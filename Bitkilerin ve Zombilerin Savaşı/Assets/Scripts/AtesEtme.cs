using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEtme : MonoBehaviour
{
	public GameObject mermi,mermininCikisNoktasi;
	private GameObject mermiParent;
	private Animator objeninAnimator;
	private SaldiranObjeyiYolaKoy SaldiriYolu;

	private void Start()
	{
		mermiParent = GameObject.Find("Mermiler");

		if (!mermiParent)
		{
			objeninAnimator = GetComponent<Animator>();
			mermiParent = new GameObject("Mermiler");
		}
		SaldiranObjeninYolunuBelirle();
	
	}
    private void Update()
    {
        if (SaldiranObjeYolaGirdiMi())
        {
			objeninAnimator.SetBool("SaldiriVarMi", true);
        }
        else
        {
			objeninAnimator.SetBool("SaldiriVarMi", false);
        }
	
	
	}


	public void AtesEt()
	{
		GameObject yeniMermi = Instantiate(mermi) as GameObject;
		yeniMermi.transform.position = mermininCikisNoktasi.transform.position;
		yeniMermi.transform.parent = mermiParent.transform;
	}
	void SaldiranObjeninYolunuBelirle()
    {
		SaldiranObjeyiYolaKoy[] oyundakiSaldiranObjelerinYollari = GameObject.FindObjectsOfType<SaldiranObjeyiYolaKoy>();

        foreach (SaldiranObjeyiYolaKoy SaldiranObjeninCiktigiYer in oyundakiSaldiranObjelerinYollari)
        {
			if (SaldiranObjeninCiktigiYer.transform.position.y == transform.position.y)
			{
				SaldiriYolu = SaldiranObjeninCiktigiYer;
			}	return;            
        }
    }
	bool SaldiranObjeYolaGirdiMi()
    {
		if(SaldiriYolu.transform.childCount <= 0)
        {
			return false;
        }

        foreach (Transform saldiranObje in SaldiriYolu.transform)
        {
			if(saldiranObje.transform.position.x > transform.position.x)
            {
				return true;
            }
        }


		return false;
	
	
	}


}

