using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public void LoadScene(string sceneName)
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(sceneName);
    }
    
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Title");
        Destroy(gameObject);
    }

    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            var currentScene = SceneManager.GetActiveScene();
            if (currentScene.name == "Title")
            {
                ExitApplication();
            }
            else
            {
                ReturnToMenu();
            }
        }
    }
}
