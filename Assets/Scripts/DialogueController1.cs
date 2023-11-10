using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController1 : MonoBehaviour
{
    public GameObject player;
    public GameObject spriteA;
    public GameObject spriteB;
    public float interactionRange = 2f;
    private bool dialogueActive = false;
    private bool isPlayerInRange = false;

    void Update()
    {
        if (Vector3.Distance(player.transform.position, spriteA.transform.position) <= interactionRange ||
            Vector3.Distance(player.transform.position, spriteB.transform.position) <= interactionRange)
        {
            isPlayerInRange = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogueActive = true;
            }
        }
        else
        {
            isPlayerInRange = false;
        }

        if (dialogueActive)
        {
            StartCoroutine(DisplayDialogue());
        }
    }

    IEnumerator DisplayDialogue()
    {
        dialogueActive = false;
        // Insert code to display dialogue here
        yield return new WaitForSeconds(0.1f);
    }

}
