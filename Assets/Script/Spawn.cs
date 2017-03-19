using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject enemigo;
	void Start () {
		InvokeRepeating("Spawnenemigo",0.0f,20.0f);
		
	}
	
	// Update is called once per frame
	void Spawnenemigo()
	{
		Instantiate(enemigo,new Vector2(-5.69f,5.63f),Quaternion.identity);
		Instantiate(enemigo,new Vector2(-3.71f,5.63f),Quaternion.identity);
		Instantiate(enemigo,new Vector2(-1.88f,5.63f),Quaternion.identity);
		Instantiate(enemigo,new Vector2(0.0f,5.63f),Quaternion.identity);
		Instantiate(enemigo,new Vector2(1.88f,5.63f),Quaternion.identity);
		Instantiate(enemigo,new Vector2(5.69f,5.63f),Quaternion.identity);
		Instantiate(enemigo,new Vector2(3.71f,5.63f),Quaternion.identity);


	}
}
