using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KazanmaKontrolu : MonoBehaviour {

	private void Update()
    {
        GetComponent<Slider>().value -= 0.0025f;

        if(GetComponent<Slider>().value <= 0f)
        {
            SceneManager.LoadScene("4.Kazanma");
        }
    }
}
