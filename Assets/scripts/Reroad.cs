using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reroad : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().name);
    }
}
