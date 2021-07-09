using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaldiranObjeyiYolaKoy : MonoBehaviour {

	public GameObject[] saldiranObjelerinPrefabi;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        foreach (GameObject saldiranObjeninPrefabi in saldiranObjelerinPrefabi)
        {
            if (SaldiriVaktiMi(saldiranObjeninPrefabi))
            {
				SaldiranObjeyiYolaYerlestir(saldiranObjeninPrefabi);
            }
        }
	}
	void SaldiranObjeyiYolaYerlestir(GameObject saldiranObje)
    {
		GameObject saldiranObjemiz = Instantiate(saldiranObje) as GameObject;
		saldiranObjemiz.transform.parent = transform;
		saldiranObjemiz.transform.position = transform.position;
    }

	bool SaldiriVaktiMi(GameObject saldiranObje)
    {
		Saldiranlar saldiriYapanObje = saldiranObje.GetComponent<Saldiranlar>();

		float dogmaBeklemeSuresi = saldiriYapanObje.kacSaniyedeBirDogacak;
		float dogmaBeklemeOrani = 1 / dogmaBeklemeSuresi;


		float sonOran = dogmaBeklemeOrani * Time.deltaTime;

		if(Random.value < sonOran)
        {
			return true;
        }
        else
        {
			return false;
        }
    }




}
