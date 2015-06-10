using UnityEngine;
using System.Collections;

public class Warp1 : MonoBehaviour {

	public Transform warptarget;

	void OnTriggerEnter2D(Collider2D other){

		Debug.Log ("An object collide");
		other.gameObject.transform.position = warptarget.position;
		Camera.main.transform.position = warptarget.position;
	
	}

}