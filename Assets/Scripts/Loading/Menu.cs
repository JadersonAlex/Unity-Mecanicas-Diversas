using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
   public void NewGame(string sceneName)
    {
        PlayerPrefs.SetString("scene", "Scenes/Loading/" + sceneName); // Scenes/Loading é o diretorio das cenas
        SceneManager.LoadScene(1); // carrega o loading
    }
}
