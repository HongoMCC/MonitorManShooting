using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorControll : MonoBehaviour
{
    public GameObject die;
    public GameObject parent;
    public GameObject test;
    public GameObject bakuhatu;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            Instantiate (bakuhatu, transform.position, Quaternion.identity);
            parent.SetActive(false);
            test.SetActive(false);
        }
    }
}
