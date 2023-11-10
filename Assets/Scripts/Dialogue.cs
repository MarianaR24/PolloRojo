using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public bool isPlayerInRange;
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            isPlayerInRange = true;
            Debug.Log("se puede iniciar un di�logo");
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            isPlayerInRange = false;
            Debug.Log("No se puede iniciar un di�logo");

        }
    }
}
