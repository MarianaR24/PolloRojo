using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Inicio");
    }
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("Boton");
            }*/
    }

    public void SonidoBoton()
    {
        FindObjectOfType<AudioManager>().Play("Boton");
    }
    public void SonidoBotonDos()
    {
        FindObjectOfType<AudioManager>().Play("Boton2");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Warning");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Sale del juego");
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
    }
}
