using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttons : MonoBehaviour {

    public Renderer rend;

    public Material material;

    public Material material2;

    

    public GameObject MainMenu;

    public GameObject LevelMenu;

    public GameObject volume;

    public GameObject buy;

    public GameObject back;

    public GameObject sett;

    public GameObject Coomingsoon;

    public GameObject BuyAds;

    public GameObject BuyLevel;

    bool contor = false;

    bool contor2 = false;

    private void Start()
    {
        
        rend.enabled = true;
        rend.sharedMaterial = material;




    }

    public void settings()
    {
        if (contor == false)
        {
            contor = true;
            volume.SetActive(true);
            buy.SetActive(true);
        }
        else
        {
            contor = false;
            volume.SetActive(false);
            buy.SetActive(false);
            BuyAds.SetActive(false);
            BuyLevel.SetActive(false);
            contor2 = false;
        }
        
    }

    public void Buy()
    {
        if (contor2 == false)
        {
            BuyAds.SetActive(true);
            BuyLevel.SetActive(true);
            contor2 = true;
        }
        else
        {
            BuyAds.SetActive(false);
            BuyLevel.SetActive(false);
            contor2 = false;
        }
    }

    public void setBack ()
    {
        volume.SetActive(false);
        buy.SetActive(false);
        back.SetActive(false);
        sett.SetActive(true);
    }

    public void Cooming()
    {
        Coomingsoon.SetActive(true);
            Invoke("coomingsoon", 1);
    }

    public void FreePlay()
    {
        Coomingsoon.SetActive(true);
        rend.sharedMaterial = material2;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Invoke("Cube", 1);
        Invoke("coomingsoon", 1);
        
    }

    public void PlayLevel(int level)
    {
        SceneManager.LoadScene(level);
    }


    public void BackButton ()
    {
        MainMenu.SetActive(true);
        LevelMenu.SetActive(false);
    }

    public void LevelSelector()
    {
        MainMenu.SetActive(false);
        LevelMenu.SetActive(true);
    }

    void coomingsoon()
    {
        Coomingsoon.SetActive(false);
    }

    void Cube()
    {
        rend.sharedMaterial = material;
    }
}
