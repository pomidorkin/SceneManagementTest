using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayableObjects : MonoBehaviour
{
    // Всё работает как нужно, но код нужно привести в порядок
    // GameObject.Find ("DisplayableObjects"); и загрузку сцен сделать поадекватнее
    GameObject displayableObjects;

    private void Start()
    {
        displayableObjects = GameObject.FindGameObjectWithTag("DisplayableObjects");
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    private void OnSceneUnloaded(Scene scene)
    {
        if(scene.name == "SceneTwo")
        {
            displayableObjects.SetActive(true);
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode lodSceneMode)
    {
        if (scene.name == "SceneTwo")
        {
            displayableObjects.SetActive(false);
        }
    }
}
