using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KaybetmeKontrolu : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("5.Kaybetme");
    }
}
