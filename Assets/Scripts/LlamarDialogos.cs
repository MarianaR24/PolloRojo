using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class LlamarDialogos : MonoBehaviour
{
    public Flowchart dialogo;
    public string rodolfo = "Rodolfo";
    public string mensaje = "JJ";
    public string mensaje2 = "Burdel";
    public string mensaje3 = "Adonay";

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

        if(other.gameObject.CompareTag("Rubio"))
        {
            SceneManager.LoadScene("Interior oficina");
        }

        if(other.gameObject.CompareTag("Burdel2"))
        {
            SceneManager.LoadScene("Interior burdel");
        }
    }

}
