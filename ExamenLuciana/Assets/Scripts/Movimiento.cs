using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	Rigidbody2D rg; 
	public int velocidad = 10;


	// Use this for initialization
	void Start () {
	
		rg = GetComponent <Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A)){ 
			mueveizquierda();                     
		}
		
		if (Input.GetKeyDown(KeyCode.D)){ 
			muevederecha();                       
		}
	
	}

	void mueveizquierda(){

		rg.velocity = new Vector2 (-velocidad, rg.velocity.y); 
	
	}

	void muevederecha(){

		rg.velocity = new Vector2(velocidad, rg.velocity.y);
	
	}

}
