using UnityEngine;
using System.Diagnostics;
using System.IO;
using System;

public class DontDestoroy : MonoBehaviour
{
    string exepath;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        exepath = Path.Combine(Application.dataPath, "../../../HongoMCCGame2024.exe");
    }
    void OnApplicationQuit()
    {
        try
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo(exepath)
            };
            process.Start();
        }
        catch(Exception ex)
        {
            UnityEngine.Debug.LogException(ex);
        }
    }
}
