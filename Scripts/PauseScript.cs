using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {

    public GameObject canvis;
    public GameObject pauseMenu;
    public Move movement;
    public Text text;
    public GameObject game;
    bool check = false;
   // public StartCount start;
    int timeLeft = 3;
 
    void Update()
    {
        text.text = (timeLeft.ToString());
        if (timeLeft == 0 && check==true)
        {
            Debug.Log("e ok");
           movement.enabled = true;
            movement.rb.AddRelativeForce(Vector3.right * movement.ForwardForce - movement.rb.velocity);
            canvis.SetActive(true);
            game.SetActive(false);
            check = false;
        }
    }

    IEnumerator LeftTime()
    {
      while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1);
           timeLeft--;
       }
   }

    public void Resumebutton()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        
        movement.enabled = false;
        movement.rb.velocity = Vector3.zero;
        timeLeft = 3;
        check = true;
        game.SetActive(true);
        StartCoroutine("LeftTime");

    }

    public void Pausebutton()
    {
        
        Time.timeScale = 0f;
        canvis.SetActive(false);
        pauseMenu.SetActive(true);

    }

    public void Menubutton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
