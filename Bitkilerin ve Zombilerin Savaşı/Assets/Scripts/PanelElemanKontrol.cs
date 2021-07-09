using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PanelElemanKontrol : MonoBehaviour
{

	public GameObject elemanPrefab;
	private PanelElemanKontrol[] panelinElemanlari;
	public static GameObject seciliEleman;
	// Use this for initialization
	void Start()
	{

		panelinElemanlari = GameObject.FindObjectsOfType<PanelElemanKontrol>();
		foreach (PanelElemanKontrol eleman in panelinElemanlari)
		{
			eleman.GetComponent<SpriteRenderer>().color = Color.black;
		}


	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnMouseDown()
	{
		seciliEleman = elemanPrefab;


		foreach (PanelElemanKontrol eleman in panelinElemanlari)
		{
			eleman.GetComponent<SpriteRenderer>().color = Color.black;
		}

		GetComponent<SpriteRenderer>().color = Color.white;

	}


}


