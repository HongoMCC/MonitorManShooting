using UnityEngine;
using System;
using System.collections;
using UnityEngine.SceneManagement;

public class RoadGame : MonoBehaviour
{
    public string SceneName;
    void OnButtonClicked()
    {
        SceneManager.LoadScene(SceneName);
    }
}