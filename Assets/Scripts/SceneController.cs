using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Method to load a specific scene
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // Method to load the "GameScene" (index 1)
    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
