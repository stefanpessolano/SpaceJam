using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public string scene;
    public void changeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
