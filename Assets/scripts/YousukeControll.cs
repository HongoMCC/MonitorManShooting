using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YousukeControll : MonoBehaviour
{
    public GameObject Yosuke;
    public Vector3 Goal;
    public float speed;
    void Start()
    {
        Goal = SetRandomPosition();
    }

    void Update()
    {
        if(Goal == Yosuke.transform.position)
        {
            Goal = SetRandomPosition();
        }
        else{
            Yosuke.transform.position = Vector2.MoveTowards(Yosuke.transform.position,Goal, speed*Time.deltaTime);
        }
    }
    private Vector3 SetRandomPosition()  // 目的地を生成、xとyのポジションをランダムに値を取得 
    {
        Vector3 random = new Vector3(Random.Range(-8, 8),-1,0);
        return random;
    }
}
