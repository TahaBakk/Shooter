using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamage : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "Ship"){
			Destroy(coll.gameObject);
		}
		Destroy(gameObject);
	}
}
