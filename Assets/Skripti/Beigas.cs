using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Beigas : MonoBehaviour {

	public AinasMainisana scene;
	public Objekti objekti;
	public GameObject EndScreen;
	public Text laiks;
	public GameObject zvaigzne1;
	public GameObject zvaigzne2;
	public GameObject zvaigzne3;
	public GameObject izkartne;
	public float time = 0f;
	string text;
	TimeSpan t;


	void Update(){
		Debug.Log (time);
		if (!scene.status)
			return;
		if (objekti.NoliktasMasinas >= 12) {
			scene.status = false;
			EndScreen.SetActive (true);
			izkartne.SetActive (true);
			rezultats (time);
			t = TimeSpan.FromSeconds (time);
			text = string.Format ("{0}:{1}:{2}", ((int)t.TotalHours), t.Minutes, t.Seconds);
			laiks.text = "Laiks: " + text;
			return;
		}
	
		time += Time.deltaTime;
}
		
	public void rezultats (float time)
	{

		if (time <= 150) {
			zvaigzne1.SetActive (true);
				zvaigzne2.SetActive (true);
				zvaigzne3.SetActive (true);
		}

		if (time > 150 && time <= 240) {
			zvaigzne1.SetActive (true);
			zvaigzne2.SetActive (true);

		} else {
			zvaigzne1.SetActive (true);

		}
	}
}
