﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NewGameBtn(string newGameLevel){
	
		SceneManager.LoadScene (newGameLevel);
	}

	public void Exit(){
	
		Application.Quit ();
	}

}
