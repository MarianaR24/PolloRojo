using System.Collections;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField, TextArea(4, 6)] private string[] dialogueLines;

    public bool isPlayerInRange;
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            isPlayerInRange = true;
            Debug.Log("se puede iniciar un diálogo");
        }
         
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            isPlayerInRange = false;
            Debug.Log("No se puede iniciar un diálogo");

        }
    }
}
