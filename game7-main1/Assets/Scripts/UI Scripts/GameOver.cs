using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
    {
        public static int _lastSceneIndex;

        void Start()
        {
            // Set the _lastSceneIndex to the build index of the current scene
            _lastSceneIndex = SceneManager.GetActiveScene().buildIndex;
        }

}
