using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneChanger : MonoBehaviour
{

    // M�todo para cargar una escena por su nombre
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // M�todo para cargar una escena por su �ndice en Build Settings
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // M�todo para salir del juego (funciona en la versi�n compilada)
    public void QuitGame()
    {
        Application.Quit();
    }
}
