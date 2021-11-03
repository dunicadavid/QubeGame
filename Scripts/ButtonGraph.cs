using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonGraph : MonoBehaviour {

    public Image image;

    public Sprite unpress;

    public Sprite press;

	
    public void Press()
    {
        image.sprite = press;
        Invoke("Unpress", 1);
    }

    void Unpress()
    {
        image.sprite = unpress;
    }

}
