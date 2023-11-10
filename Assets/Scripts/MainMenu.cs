using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("Boton");
            }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Escena_1");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Sale del juego");
    }

    public void Intro()
    {
        SceneManager.LoadScene("Intro");
    }
}
