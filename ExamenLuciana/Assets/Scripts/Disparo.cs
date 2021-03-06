﻿using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

	public GameObject bala; //variable del objeto que usaremos como proyectil
	public Vector2 fuerzadisparo; //fuerza con la que lanzamos la vala
	private AudioSource au; //cogemos la variable del audio

	// Use this for initialization
	void Start () {
	
		au = GetComponent<AudioSource> (); 
	}
	
	// Update is called once per frame
	void Update () {
		disparo(); //llamamos a la funcion en todo momento
	}

	void disparo(){
	
		if (Input.GetKeyDown(KeyCode.Space)){ //cuando presionamos espacio
		
			GameObject nueva_bala = (GameObject) Instantiate(bala,transform.position, transform.rotation); //creamos un nuevo proyectil
			nueva_bala.GetComponent<Rigidbody2D>().AddForce(fuerzadisparo); //a este proyectil le añadimos  una fuerza
			au.Play (); //reproducimos el sonido
			Debug.Log ("sueno");//comprobamos si suena
			Destroy(nueva_bala,2); //destruimos el proyectil tras 2 segundos

		}
	}


}
