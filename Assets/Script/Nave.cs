using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour {


	Vector2 naveTras;
	float factorVel;
	public GameObject bullet;

	// Use this for initialization
	void Start () {
		naveTras = new Vector2(0.0f,0.0f);
		factorVel = 10.0f;
		
	}
	
	// Update is called once per frame
	void Update () {


		naveTras.x= 0.0f;

		if(Input.GetKey(KeyCode.RightArrow))
			{
				naveTras.x= factorVel * Time.deltaTime;
				transform.Translate(naveTras);
			}
			
		if(Input.GetKey(KeyCode.LeftArrow))
			{
				naveTras.x= -1*factorVel * Time.deltaTime;
				transform.Translate(naveTras);
			}

		if(Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(bullet,transform.position,Quaternion.identity);
		}
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

