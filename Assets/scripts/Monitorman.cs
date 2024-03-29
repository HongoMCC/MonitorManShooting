using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Monitorman : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject forward;
    public int number;
    public int y;
    public Vector3 movement;
    public Vector3 Goal;
    public float speed;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        number = 1;
        Goal = SetRandomPosition();
        InvokeRepeating("UpdateNum", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = this.transform.position.x - Goal.x;
        if(movement.x == 0)
        {
            forward.SetActive(true);
            right.SetActive(false);
            left.SetActive(false);
        }
        if(movement.x < 0)
        {
            forward.SetActive(false);
            right.SetActive(true);
            left.SetActive(false);
        }
        if(movement.x > 0)
        {
            forward.SetActive(false);
            right.SetActive(false);
            left.SetActive(true);
        }
        //EndoControllの方と同じ
        if(Goal == this.transform.position)
        {
            Instantiate(Bullet,transform.position, Quaternion.identity);
            Goal = SetRandomPosition();
        }
        else{
            this.transform.position = Vector2.MoveTowards(this.transform.position,Goal, speed*Time.deltaTime);
        }
        
    }
    private Vector3 SetRandomPosition()  // 目的地を生成、xとyのポジションをランダムに値を取得 
    {
        Vector3 random = new Vector3(Random.Range(-7, 7), y,0);
        return random;
    }
    void UpdateNum()
    {
        if(number == 3)
        {
            number = 1;
        }
        else
        {
            number++;
        }
    }
}