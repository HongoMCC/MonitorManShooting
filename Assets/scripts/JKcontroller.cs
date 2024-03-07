using UnityEngine;
using System.Collections;
using System.Threading.Tasks;

public class JKcontroller : MonoBehaviour 
{
	public float speed = 0.01f;
	public GameObject bullet;
	//public int cooltime = 1000;//ミリ秒
	public bool IsCoolTime;
	public GameObject Lose;
	public GameObject Win;
	public GameObject Endo1;
	public GameObject Endo2;
	public GameObject Endo3;
	void Start(){
		IsCoolTime = false;
	}
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow))
		{
			if(transform.position.x <-7)
			{
				return;
			}
			else
			{
				transform.Translate (-speed, 0, 0);
			}
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			if(transform.position.x>7)
			{
				return;
			}
			else
			{
				transform.Translate (speed, 0, 0);
			}
		}
		if(Input.GetKeyDown(KeyCode.Space))
		{
			//Instantiate(bullet,transform.position, Quaternion.identity);
			if(IsCoolTime == false)
			{
				Instantiate(bullet,transform.position, Quaternion.identity);
				Wait();
			}
			else{return;}
		}
		if(!Endo1.activeSelf && !Endo2.activeSelf && !Endo3.activeSelf)
		{
			Win.SetActive(true);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "endobullet")
		{
			Lose.SetActive(true);
		}
	}
	async void Wait()
	{
		IsCoolTime = true;
		await Task.Delay(750);
		IsCoolTime = false;
	}
}
