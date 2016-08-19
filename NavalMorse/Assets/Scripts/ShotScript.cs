using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

	public float speed;
	public float timer; //in seconds
	public float damage;
	
	public Rigidbody2D rb;
	
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = transform.up * speed * Time.deltaTime;
	}

	void Update()
	{
		timer -= Time.deltaTime;

		if (timer <= 0) 
		{
			Destroy(gameObject);
		}
	}

	float getDamage(){
		return damage;
	}

	void setDamage(float damage){
		this.damage = damage;
	}

}
