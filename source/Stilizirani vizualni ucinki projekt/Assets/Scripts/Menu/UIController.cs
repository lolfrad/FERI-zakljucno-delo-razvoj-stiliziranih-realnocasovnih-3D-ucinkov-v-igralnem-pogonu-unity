using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public void OpenSceneButtonClick(string sceneName)
    {
        Controller.Instance.sceneController.OpenScene(sceneName);
    }

    public void ReturnToMenuButtonClick()
    {
        Controller.Instance.sceneController.ReturnToMenu();
    }

    public void CloseGameButtonClick()
    {
        Controller.Instance.sceneController.CloseGame();
    }

    public void ResetSceneButtonClick()
    {
        Controller.Instance.sceneController.ResetScene();
    }
}
