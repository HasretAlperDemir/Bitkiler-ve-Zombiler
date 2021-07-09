using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class sahneKontrolu : MonoBehaviour
{

    public float sonrakiSahneninYuklenmeSuresi;

    public void Start()
    {
        if(SceneManager.GetActiveScene().name == "0.Menuden Onceki Sahne")
        {
            Invoke("SonrakiSahne", sonrakiSahneninYuklenmeSuresi);
        }
        

    }

    public void SonrakiSahne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OyunCikis()
    {
        Application.Quit();
    }

    public void IsimleSahneCagirma(string sahneIsmi)
    {
        SceneManager.LoadScene(sahneIsmi);
    }

    public void IndexleSahneCagirma(int sahneIndexi)
    {
        SceneManager.LoadScene(sahneIndexi);
    }


}


