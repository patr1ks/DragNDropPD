using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Importé lai varetu mainit ainas
using UnityEngine.SceneManagement;

public class AinasMainisana : MonoBehaviour {
	public Objekti objekti;
	public bool game = false;


	//Nokliśḱinot uz pogas "Back" aizvedís uz sákuma ainu.
	public void Sakums() {
		SceneManager.LoadScene (0, LoadSceneMode.Single);
	}
	//Noklikśḱinot uz pogas "Start" vai "Restart" aizved uz speles ainu.
	public void Spele() {
		SceneManager.LoadScene (1, LoadSceneMode.Single);
		game = true;
	}
		
	//Noklikśḱinot uz pogas "Quit" aizver aplikáciju.
	public void Beigt() {
		Application.Quit ();
	}
		
	}
