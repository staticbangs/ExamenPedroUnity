using UnityEngine;
using System.Collections;

public class MovimientoEnemigo : MonoBehaviour {

	Rigidbody2D rg; //rigidbody del objeto
	public int Velocidad; //Velocidad con la que se moveran los enemigos

	// Use this for initialization
	void Start () {

		rg = GetComponent <Rigidbody2D>(); //llamamos al rigidbody para poder ponerle fuerza luego
		Destroy (gameObject,2.5f);
	}
	
	// Update is called once per frame
	void Update () {

		rg.velocity = new Vector2(0, Velocidad); //La velocidad del rigidbody, sera la que añadamos en la variable velocidad
	
	}

	void OnCollisionEnter2D (Collision2D objeto){
	if(objeto.transform.tag == "Player"){
			Destroy(objeto.gameObject);
		
		}
	}
}
