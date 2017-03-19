using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody2D>().AddForce(transform.up*250);
		
	}
	
	// Update is called once per frame
	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.name == "enemyspaceship(Clone)")
		{
			Destroy(this.gameObject);
		}

		if(col.gameObject.name == "enemybala(Clone)")
		{
			Destroy(this.gameObject);
		}
	}
}
