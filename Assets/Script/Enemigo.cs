using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

	public GameObject balaEnemiga;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().AddForce(-1*transform.up*200000);
		InvokeRepeating("Spawn",0.5f,5.0f);
		
	}
	
	// Update is called once per frame


	void Spawn()
	{

		int x = Random.Range(0,7);

		if(x==0)
		{
			Instantiate(balaEnemiga,transform.position,Quaternion.identity);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.name == "bala(Clone)")
		{
			Destroy(this.gameObject);
		}
	}
}
