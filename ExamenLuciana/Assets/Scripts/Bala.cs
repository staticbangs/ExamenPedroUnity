using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D objeto){
		if(objeto.transform.tag =="enemigo"){
			Destroy(objeto.gameObject);
			Destroy(gameObject);
		}
		
	}
}
