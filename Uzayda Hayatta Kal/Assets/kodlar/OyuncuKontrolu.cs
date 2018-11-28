using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrolu : MonoBehaviour {

    Rigidbody fizik;
	float horizontal = 0;
	float vertical = 0;
	Vector3 vec;
	void Start () {

		fizik = GetComponent<Rigidbody> ();

       
		
	}
	
	
	void FixedUpdate () {
		horizontal=Input.GetAxis("Horizontal");
		vertical=Input.GetAxis("Vertical");
		vec = new Vector3(horizontal,0,vertical);

		fizik.velocity = vec;
	}
}
