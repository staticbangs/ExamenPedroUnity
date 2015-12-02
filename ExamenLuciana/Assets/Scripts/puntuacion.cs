using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class puntuacion : MonoBehaviour {

	public int puntos = 0; //variable de puntos
	public Text texto_puntos; // texto al que le va a afectar

	void OnTriggerEnter2D(Collider2D objeto){ //cuando entra un objeto 2D 
	if(objeto.transform.tag == "enemigo"){//si el objeto tiene la etiqueta item
			puntos = puntos + 1; //se añade un punto a la variable puntos
			texto_puntos.text = ""+puntos; // y el texto tambien cambia
			Debug.Log(puntos); //saca por consola los puntos
		}
	}
}
