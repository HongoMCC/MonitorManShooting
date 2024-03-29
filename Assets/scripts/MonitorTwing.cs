using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorTwing : MonoBehaviour
{
    public Monitorman monitorMan;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    // Update is called once per frame
    void Update()
    {
        if(monitorMan.number == 1)
        {
            one.SetActive(true);
            two.SetActive(false);
            three.SetActive(false);
        }
        if(monitorMan.number == 2)
        {
            one.SetActive(false);
            two.SetActive(true);
            three.SetActive(false);
        }
        if(monitorMan.number == 3)
        {
            one.SetActive(false);
            two.SetActive(false);
            three.SetActive(true);
        }   
    }
}
