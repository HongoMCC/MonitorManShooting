using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OneToTwo : MonoBehaviour
{
    public string SceneName;//next
    public void Clicked()
    {
        SceneManager.LoadScene(SceneName);
    }
}
