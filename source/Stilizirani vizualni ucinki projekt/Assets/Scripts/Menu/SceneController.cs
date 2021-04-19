using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string currentScene; 

    public void OpenScene(string sceneName)
    {
        currentScene = sceneName;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void ReturnToMenu()
    {
        currentScene = "Main menu";
        SceneManager.LoadScene(currentScene, LoadSceneMode.Single);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(currentScene, LoadSceneMode.Single);
    }
}
