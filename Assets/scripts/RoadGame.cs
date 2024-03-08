using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class RoadGame : MonoBehaviour
{
    public string SceneName;
    public void OnButtonClicked()
    {
        SceneManager.LoadScene(SceneName);
    }
}