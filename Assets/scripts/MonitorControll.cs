using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorControll : MonoBehaviour
{
    public GameObject die;
    public GameObject parent;
    public GameObject test;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            die.SetActive(true);
            parent.SetActive(false);
            test.SetActive(false);
        }
    }
}
