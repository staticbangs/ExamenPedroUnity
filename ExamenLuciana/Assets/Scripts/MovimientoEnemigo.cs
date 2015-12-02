using UnityEngine;
using System.Collections;

public class MovimientoEnemigo : MonoBehaviour {

	Rigidbody2D rg; //rigidbody del objeto
	public int Velocidad; //Velocidad con la que se moveran los enemigos
	public GameObject explosion; //animacion que usaremos para cuando explote
	public AudioSource au; //cogemos la variable del audio

	// Use this for initialization
	void Start () {

		rg = GetComponent <Rigidbody2D>(); //llamamos al rigidbody para poder ponerle fuerza luego
		Destroy (gameObject,2.5f);
		au = GetComponent<AudioSource> (); 
	}
	
	// Update is called once per frame
	void Update () {

		rg.velocity = new Vector2(0, Velocidad); //La velocidad del rigidbody, sera la que añadamos en la variable velocidad
	
	}

	void OnCollisionEnter2D (Collision2D objeto){
	if(objeto.transform.tag == "Player"){
			GameObject ex = (GameObject)Instantiate(explosion, objeto.transform.position, objeto.transform.rotation);
			Destroy(ex,0.9f);
			au.Play(); //reproducimos el sonido
			Debug.Log ("sueno");
			Destroy(objeto.gameObject);
			Application.LoadLevel("menu");
		
		}
	}
}
