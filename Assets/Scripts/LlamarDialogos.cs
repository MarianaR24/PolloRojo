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
    private bool rodolfoColl = false;
    public string diego = "Diego";
    private bool diegoColl = false;
    public string diego2 = "Diego2";
    public bool diegoColl2 = false;
    public string toño = "Toño";
    private bool toñoColl = false;
    public string pablin = "Pablin";
    private bool pablinColl = false;
    public string mensaje = "JJ";
    private bool jjColl = false;
    public string mensaje2 = "Burdel";
    private bool burdelColl = false;
    public string mensaje3 = "Adonay";
    private bool adonayColl = false;
    public string inicio = "Inicio";

    private void Start()
    {
        pantalla.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) && pablinColl)
        {
            dialogo.SendFungusMessage(pablin);
        }
        
        if(Input.GetKeyDown(KeyCode.Z) && rodolfoColl)
        {
            dialogo.SendFungusMessage(rodolfo);
        }

        if(Input.GetKeyDown(KeyCode.Z) && diegoColl)
        {
            dialogo.SendFungusMessage(diego);
        }

        if(Input.GetKeyDown(KeyCode.Z) && jjColl)
        {
            dialogo.SendFungusMessage(mensaje);
        }

        if(Input.GetKeyDown(KeyCode.Z) && burdelColl)
        {
            dialogo.SendFungusMessage(mensaje2);
        }

        if(Input.GetKeyDown(KeyCode.Z) && adonayColl)
        {
            dialogo.SendFungusMessage(mensaje3);
        }

        if(Input.GetKeyDown(KeyCode.Z) && diegoColl2)
        {
            dialogo.SendFungusMessage(diego2);
        }

        if(Input.GetKeyDown(KeyCode.Z) && toñoColl)
        {
            dialogo.SendFungusMessage(toño);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("JJ"))
        {
            jjColl = true;
        }

        if(other.gameObject.CompareTag("Burdel"))
        {
            burdelColl = true;
        }

        if(other.gameObject.CompareTag("Adonay"))
        {
            adonayColl = true;
        }

        if(other.gameObject.CompareTag("Rodolfo"))
        {
            rodolfoColl = true;
        }

        if(other.gameObject.CompareTag("Diego"))
        {
            diegoColl = true;
        }

        if(other.gameObject.CompareTag("Diego2"))
        {
            diegoColl2 = true;
        }

        if(other.gameObject.CompareTag("Toño"))
        {
            toñoColl = true;
        }

        if(other.gameObject.CompareTag("Pablin"))
        {
            pablinColl = true;
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

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("JJ"))
        {
            jjColl = false;
        }

        if(other.gameObject.CompareTag("Burdel"))
        {
            burdelColl = false;
        }

        if(other.gameObject.CompareTag("Adonay"))
        {
            adonayColl = false;
        }

        if(other.gameObject.CompareTag("Rodolfo"))
        {
            rodolfoColl = false;
        }

        if(other.gameObject.CompareTag("Diego"))
        {
            diegoColl = false;
        }

        if(other.gameObject.CompareTag("Diego2"))
        {
            diegoColl2 = false;
        }

        if(other.gameObject.CompareTag("Toño"))
        {
            toñoColl = false;
        }

        if(other.gameObject.CompareTag("Pablin"))
        {
            pablinColl = false;
        }
    }

    public void ComienzoDialogos()
    {
        dialogo.SendFungusMessage(inicio);
    }

    IEnumerator Carga()
    {
        yield return new WaitForSeconds(3f);
        yield break;
    }

}
