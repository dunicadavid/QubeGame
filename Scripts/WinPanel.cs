using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour {

    public GameObject UI;

    

    public void NextLevel()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("video", new ShowOptions() { resultCallback = HandleAdResult });
        }
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Continue()
    {
        
        UI.SetActive(false);
        

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case ShowResult.Skipped:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case ShowResult.Failed:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
        }
    }

}
