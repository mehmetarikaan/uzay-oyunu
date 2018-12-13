using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunKontrol : MonoBehaviour {

	public GameObject Asteroid;
	public Vector3 randomPos;
	public float baslangicBekleme;
	public float olusturmaBekleme;
	public float donguBekleme;
	public Text text;
	int score;
	void Start () {

		score=0;
		text.text = "score: "+score;
		StartCoroutine(olustur());

	}
	IEnumerator	olustur()
	{
		yield return new WaitForSeconds (baslangicBekleme);
		while(true){
			for(int i=0; i<10; i++)
		{
		Vector3 vec = new Vector3(Random.Range(-randomPos.x,randomPos.x),0,randomPos.z);
		Instantiate(Asteroid,vec,Quaternion.identity);
		yield return new WaitForSeconds (olusturmaBekleme);
		}

		yield return new WaitForSeconds (donguBekleme);

		}
		
		
	}
	public void ScoreArttir(int gelenScore){

		score+=gelenScore;
		text.text = "score: "+score;
		

	}
}
