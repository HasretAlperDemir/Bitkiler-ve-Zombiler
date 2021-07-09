using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilki : MonoBehaviour {

	private Animator tilkiAnimator;
	private Saldiranlar saldiranObje;

	// Use this for initialization
	void Start () {
		tilkiAnimator = GetComponent<Animator>();
		saldiranObje = GetComponent<Saldiranlar>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
    {
		GameObject tilkininEtkilesimeGirdigiObje = collision.gameObject;

        if (!tilkininEtkilesimeGirdigiObje.GetComponent<Savunanlar>())
        {
			return;
        }
    
        else if (tilkininEtkilesimeGirdigiObje.GetComponent<Tas>())
        {
			tilkiAnimator.SetTrigger("ziplamaİslemi");
        }
        else
        {
			tilkiAnimator.SetBool("SaldiriVarMi", true);
			saldiranObje.HedefiBelirle(tilkininEtkilesimeGirdigiObje);
        }
	
	
	
	
	
	}




}
