using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    public Text dialogueText;
    public SpriteRenderer dialogueBox;

    private string[] dialogueLines;
    private int currentLine;

    private void Start()
    {
        dialogueLines = new string[] { "Line 1", "Line 2", "Line 3" };
        currentLine = 0;
        dialogueBox.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentLine < dialogueLines.Length)
        {
            dialogueBox.gameObject.SetActive(true);
            dialogueText.text = dialogueLines[currentLine];
            currentLine++;
        }
        else if (currentLine >= dialogueLines.Length)
        {
            dialogueBox.gameObject.SetActive(false);
        }
    }
}

