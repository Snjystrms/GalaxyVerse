using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToGame : MonoBehaviour
{
  
    void Start()
    {
        StartCoroutine(LoadGame());
    }
     IEnumerator LoadGame()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);
    }
    
}
 