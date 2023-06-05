using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Importé lai varetu mainit ainas
using UnityEngine.SceneManagement;

public class AinasMainisana : MonoBehaviour {

	//Pievieno lai varetu paradit rezultatu un beigu ainu
	public Objekti objekti;
	public Text time;
	public GameObject zvaigzne1;
	public GameObject zvaigzne2;
	public GameObject zvaigzne3;
	public float laiks = 0f;
	string teksts;
	TimeSpan t;


	//Nokliśḱinot uz pogas "Back" aizvedís uz sákuma ainu.
	public void Sakums() {
		SceneManager.LoadScene (0, LoadSceneMode.Single);
	}
	//Noklikśḱinot uz pogas "Start" vai "Restart" aizved uz speles ainu.
	public void Spele() {
		SceneManager.LoadScene (1, LoadSceneMode.Single);
	}
		
	//Noklikśḱinot uz pogas "Quit" aizver aplikáciju.
	public void Beigt() {
		Application.Quit ();
	}

	public void EndScreen(){
		//if(){
		SceneManager.LoadScene (2, LoadSceneMode.Single);
		//}
	}


}
