using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Scene_Controller 
{

    public static void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public static void Restart()
    {
        SceneManager.LoadScene(gameover._lastSceneIndex);
    }

    public static void NextLevel()
    {
        // Increment the _lastSceneIndex by 1 and load the next scene
        int nextSceneIndex = gameover._lastSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);

    }


}
