using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loading : MonoBehaviour
{
   
    void Start()
    {
        StartCoroutine(LoadScene());
    }

    
   IEnumerator LoadScene()
    {
        AsyncOperation asynLoad = SceneManager.LoadSceneAsync(PlayerPrefs.GetString("scene"));

        while (!asynLoad.isDone) // enquanto for falso
        {
            yield return null;  
        }
    }
}
