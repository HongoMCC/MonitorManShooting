using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class EndoControll : MonoBehaviour
{
    public GameObject Endo;
    public GameObject EndoBullet;
    public GameObject EndoDie;
    public Vector3 Goal;
    public float speed;
    public int y;
    void Start()
    {
        Goal = SetRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if(Goal == Endo.transform.position)
        {
            Instantiate(EndoBullet,transform.position, Quaternion.identity);
            Goal = SetRandomPosition();
        }
        else{
            Endo.transform.position = Vector2.MoveTowards(Endo.transform.position,Goal, speed*Time.deltaTime);
        }
    }
    private Vector3 SetRandomPosition()  // 目的地を生成、xとyのポジションをランダムに値を取得 
    {
        Vector3 random = new Vector3(Random.Range(-7, 7), y,0);
        return random;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            EndoDie.SetActive(true);
            Endo.SetActive(false);
            Delay();
            //EndoDie.SetActive(false);
        }
    }
    async void Delay()
    {
        await Task.Delay(1000);
    }
}
