using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warning : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    
    }
}
