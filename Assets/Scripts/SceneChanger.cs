using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneChanger : MonoBehaviour
{

    // Método para cargar una escena por su nombre
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Método para cargar una escena por su índice en Build Settings
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // Método para salir del juego (funciona en la versión compilada)
    public void QuitGame()
    {
        Application.Quit();
    }
}
