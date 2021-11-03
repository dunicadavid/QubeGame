using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolumeSett : MonoBehaviour {
   
    public Image image;

    public Sprite vol1;

    public Sprite vol2;

    public Sprite vol3;

    public Sprite vol4;

    static int contor = 1;

    

    public void Start()
    {


        if (contor == 1)
        {
            image.sprite = vol1;
           
        }
        else if (contor == 2)
        {
            image.sprite = vol2;
        
        }
        else if (contor == 3)
        {
            image.sprite = vol3;
           
        }
        else if (contor == 4)
        {
            image.sprite = vol4;
          
        }
    }

    public void Press()
    {
        if(contor==1)
        {
            image.sprite = vol2;
            contor = 2;
        }else if (contor == 2)
        {
            image.sprite = vol3;
            contor = 3;
        }else if (contor == 3)
        {
            image.sprite = vol4;
            contor = 4;
        }else if (contor == 4)
        {
            image.sprite = vol1;
            contor = 1;
        }
    }

   
}
