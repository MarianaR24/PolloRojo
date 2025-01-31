using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class LlamarDialogos : MonoBehaviour
{
    public Flowchart dialogo;
    public GameObject pantalla;
    public string rodolfo = "Rodolfo";
    public string diego = "Diego";
    public string diego2 = "Diego2";
    public string toño = "Toño";
    public string pablin = "Pablin";
    public string mensaje = "JJ";
    public string mensaje2 = "Burdel";
    public string mensaje3 = "Adonay";
    public string inicio = "Inicio";

    private void Start()
    {
        pantalla.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("JJ"))
        {
            dialogo.SendFungusMessage(mensaje);
        }

        if(other.gameObject.CompareTag("Burdel"))
        {
            dialogo.SendFungusMessage(mensaje2);
        }

        if(other.gameObject.CompareTag("Adonay"))
        {
            dialogo.SendFungusMessage(mensaje3);
        }

        if(other.gameObject.CompareTag("Rodolfo"))
        {
            dialogo.SendFungusMessage(rodolfo);
        }

        if(other.gameObject.CompareTag("Diego"))
        {
            dialogo.SendFungusMessage(diego);
        }

        if(other.gameObject.CompareTag("Diego2"))
        {
            dialogo.SendFungusMessage(diego2);
        }

        if(other.gameObject.CompareTag("Toño"))
        {
            dialogo.SendFungusMessage(toño);
        }

        if(other.gameObject.CompareTag("Pablin"))
        {
            dialogo.SendFungusMessage(pablin);
        }

        if(other.gameObject.CompareTag("Rubio"))
        {
            pantalla.SetActive(true);
            StartCoroutine(Carga());
            SceneManager.LoadScene("Interior oficina");
        }

        if(other.gameObject.CompareTag("Burdel2"))
        {
            pantalla.SetActive(true);
            StartCoroutine(Carga());
            SceneManager.LoadScene("Interior burdel");
        }

        if(other.gameObject.CompareTag("Bar"))
        {
            pantalla.SetActive(true);
            StartCoroutine(Carga());
            SceneManager.LoadScene("Interior bar");
        }

        if(other.gameObject.CompareTag("Salida"))
        {
            pantalla.SetActive(true);
            StartCoroutine(Carga());
            SceneManager.LoadScene("Bosque");
        }
    }

    public void Comienzo()
    {
        dialogo.SendFungusMessage(inicio);
    }

    IEnumerator Carga()
    {
        yield return new WaitForSeconds(3f);
        yield break;
    }

}
