using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCount : MonoBehaviour {

    int timeLeft = 3;

    public Text countDownText;

    public Move movement;

    public Text Score1;

    public Text Score2;

    public GameObject button;

    bool ok = false;

   
    void Start () {
        

        StartCoroutine("LeftTimeStart");
        movement.enabled = false;
        Score1.enabled = false;
        Score2.enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
        countDownText.text = (timeLeft.ToString());
        if (timeLeft == 0 && ok == false) 
        {
            button.SetActive(true);
            ok = true;
            movement.enabled = true;
            countDownText.enabled = false;
            Score2.enabled = true;

            Score1.enabled = true;
            Debug.Log("merge");
        }
       


    }

    IEnumerator LeftTimeStart()
    {
        while (timeLeft > 0)
        {
            Debug.Log("sec");
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }

}
