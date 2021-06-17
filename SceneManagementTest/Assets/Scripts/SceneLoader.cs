using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MLAPI.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        // На данном этапе активная сцена это SampleScene
        SceneManager.LoadScene("SceneTwo", LoadSceneMode.Additive);
        StartCoroutine(WaitForSceneLoad(SceneManager.GetSceneByName("SceneTwo")));
    }

    public void LoadPreviousScene()
    {
            SceneManager.UnloadSceneAsync("SceneTwo");
    }

    // Это корутина ждёт пока сцена загрузится и делает её активной
    public IEnumerator WaitForSceneLoad(Scene scene)
    {
        while (!scene.isLoaded)
        {
            yield return null;
        }
        SceneManager.SetActiveScene(scene);
    }

}
