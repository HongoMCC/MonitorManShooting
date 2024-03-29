using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorControll : MonoBehaviour
{
    public GameObject die;
    public GameObject parent;
    public GameObject This;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            die.SetActive(true);
            This.SetActive(false);
            parent.SetActive(false);
        }
    }
}
