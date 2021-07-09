using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuyuYavascaGoster : MonoBehaviour {

	public float yavascaGostermeSuresi;

	private Color guncelRenk = Color.black;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad < yavascaGostermeSuresi)
        {
			float alfaDegisimi = Time.deltaTime / yavascaGostermeSuresi;
			guncelRenk.a -= alfaDegisimi;
			GetComponent<Image>().color = guncelRenk;
        }
        else
        {
			gameObject.SetActive(false);
        }
	
	}   






}
