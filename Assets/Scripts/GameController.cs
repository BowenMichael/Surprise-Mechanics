using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private bool pause = true;
    private string previousScene;

    public bool getGameState()
    {
        return pause;
    }
    public void toggleGameState()
    {
        pause = !pause;
    }
    public void changeScene(string newScene)
    {
        previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName: newScene);
    }
}
