using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using Fungus;

public class Guardado : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        //LoadGame();
        Debug.Log("Ruta del Archivo: " + Application.persistentDataPath + "/savefile.json");
    }

    void Update()
    {
        
    }

    public void SaveGame()
    {
        Datos data = new Datos();
        data.sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        data.playerPosX = player.transform.position.x;
        data.playerPosY = player.transform.position.y;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadGame()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Datos loadedData = JsonUtility.FromJson<Datos>(json);

            if(SceneManager.GetActiveScene().name != loadedData.sceneName)
            {
                SceneManager.LoadScene(loadedData.sceneName);
                StartCoroutine(RestoreDataAfterSceneLoad(loadedData));
                return;
            }

            RestoreGameData(loadedData);
            
        }
    }

    private IEnumerator RestoreDataAfterSceneLoad(Datos loadedData)
    {
        yield return new WaitForSeconds(0.5f);

        RestoreGameData(loadedData);
    }

    private void RestoreGameData(Datos loadedData)
    {
        player.transform.position = new Vector2(loadedData.playerPosX, loadedData.playerPosY);
    }

}
