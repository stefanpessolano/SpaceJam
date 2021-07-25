using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColiderScene : MonoBehaviour
{
    public int sceneIndex;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("test");
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
