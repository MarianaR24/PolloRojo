using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogoIntro : MonoBehaviour
{
    [SerializeField] private GameObject dialogoMark;
    [SerializeField] private TMP_Text textoDialogo;
    [SerializeField] private string[] lineas;
    private int lineIndex = 0;
    private string currentText = "";
    [SerializeField] private bool escribiendo = false;


    void Start()
    {
        StartCoroutine(Comenzar());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !escribiendo)
        {
            if (lineIndex <= lineas.Length)
            {
                StartCoroutine(AnimateText());
                lineIndex++;
                escribiendo = false;
            }
        }

        if (lineIndex == 6)
        {
            StartCoroutine(CambiodeEscena());
        }

    }

    private IEnumerator AnimateText()
    {
        if (lineIndex <= lineas.Length)
        {
            for (int i = 0; i <= lineas[lineIndex].Length; i++)
            {
                escribiendo = true;
                currentText = lineas[lineIndex].Substring(0, i);
                textoDialogo.text = currentText;
                yield return new WaitForSeconds(0.05f); // Tiempo de espera entre cada letra
                escribiendo = false;
            }
        }
    }

    private IEnumerator Comenzar()
    {
        yield return new WaitForSeconds(1f); // Tiempo de espera entre cada letra
        StartCoroutine(AnimateText());

    }

    private IEnumerator CambiodeEscena()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Casa");
    }
}
