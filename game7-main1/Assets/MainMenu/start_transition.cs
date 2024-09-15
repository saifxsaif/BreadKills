using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_transition : MonoBehaviour
{
    public void Play_Game()
    {
        SceneManager.LoadSceneAsync(1);

    }

    public void Quit_Game()
    {
        Application.Quit();

    }

}
