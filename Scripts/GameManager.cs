using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class GameManager : MonoBehaviour {

    bool gameEnd = false;

    bool check = false;//daca castigi si cazi de pe platforma

    public float RestartTime = 2f;

    public GameObject completlevelUI;

    ///public GameObject loselevelUI;

    public Move movement;

    public void completeLevel()
    {
        if(gameEnd==false)
        {
            completlevelUI.SetActive(true);
            check = true;
        }
        
        
    }

	public void EndGame ()
    {
        if(gameEnd==false && check==false)
        {
            gameEnd = true;

            if(Advertisement.IsReady())
            {
                Advertisement.Show("video", new ShowOptions() { resultCallback = HandleAdResult });
            }


            //Invoke("Restart", RestartTime);
        }
        
    }

    private void HandleAdResult(ShowResult result)
    {
        switch(result)
        {
            case ShowResult.Finished:
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
            case ShowResult.Skipped:
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
            case ShowResult.Failed:
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
        }
    }

    

    
}
