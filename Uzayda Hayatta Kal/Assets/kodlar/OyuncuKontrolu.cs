using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrolu : MonoBehaviour {
	
    Rigidbody fizik;
	float horizontal = 0;
	float vertical = 0;
	Vector3 vec;
	public float karakterHiz;
	public float minX;
	public float maxX;
	public float minZ;
	public float maxZ;
	public float egim;
	float atesZamani = 0;
	public float atesGecenZamani;
	public GameObject Kursun;
	public Transform KursunNeredenCiksin;
	AudioSource audio;

	void Start () {

		fizik = GetComponent<Rigidbody> ();
		audio = GetComponent<AudioSource> ();
       
		
	}
	
	void Update()
	{
		if(Input.GetButton("Fire1")&& Time.time>atesZamani)
		{
			atesZamani = Time.time+ atesGecenZamani;
			
			Instantiate(Kursun, KursunNeredenCiksin.position,Quaternion.identity);
			audio.Play();
		}
	}



	void FixedUpdate () {
		horizontal=Input.GetAxis("Horizontal");
		vertical=Input.GetAxis("Vertical");
		vec = new Vector3(horizontal,0,vertical);

		fizik.velocity = vec*karakterHiz;

		fizik.position = new Vector3 
		(
			Mathf.Clamp(fizik.position.x,minX,maxX),
			0.0f,
			Mathf.Clamp(fizik.position.z,minZ,maxZ)
		);

		fizik.rotation = Quaternion.Euler(0,0,fizik.velocity.x*-egim);
	}
}
