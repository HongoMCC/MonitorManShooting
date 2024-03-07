using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndoBullet : MonoBehaviour
{
    public float speed = 0.03f;
    //public float rotSpeed;
    void Start()
    {
        //this.rotSpeed = 5f + 3f * Random.value;
    }
    void Update()
    {
        transform.Translate (0,-speed, 0);
        //transform.Rotate(0, 0, rotSpeed );
        //Delay();
		if (transform.position.y < -6)
        {
            Destroy (gameObject);
		}   
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "yousuke")
        {
            Destroy(gameObject);
        }
    }
}
