using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class bullet : MonoBehaviour
{
    //public Rigidbody rb;
    //public Animator anim;
    public float speed = 0.03f;
    public GameObject bakuhatu;
    //public Vector2 vector2;
    //public GameObject yousuke;
    //public GameObject Endo;//遠藤の消失判定はEndoControll.csにて
    //public GameObject EndoBullet;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
            //Instantiate(bulllet);  
            //while(true)
            //{
                transform.Translate (0,speed, 0);
                //Delay();
		        if (transform.position.y > 6)
                {
                    Destroy (gameObject);
                    //break;
		        }
            //}
            //anim.SetBool("Space", true);
            //rb.AddForce(vector2,ForceMode.Acceleration);
        //}
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "yousuke")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "endobullet")
        {
            Instantiate (bakuhatu, transform.position, Quaternion.identity);
            Destroy (other.gameObject);
            Destroy(gameObject);
        }
    }
    //async void Delay()
    //{
    //    await Task.Delay(30);
    //}
}
