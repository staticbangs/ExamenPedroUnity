using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {

	public GameObject explosion; //animacion que usaremos para cuando explote

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D objeto){
		if(objeto.transform.tag =="enemigo"){
			GameObject ex = (GameObject)Instantiate(explosion, objeto.transform.position, objeto.transform.rotation);
			Destroy(ex,0.9f);
			Destroy(objeto.gameObject);
			Destroy(gameObject);
		}
		
	}
}
