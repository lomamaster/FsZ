﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public GameObject PauseUI;

	private bool paused = false;

	void start () {

		PauseUI.SetActive (false);

	}

	void Update (){
		if (Input.GetButtonDown ("Pause")) {
			paused = !paused;
		}
		if (paused) {
			PauseUI.SetActive (true);
			Time.timeScale = 0;
		}
		if (!paused) {
			PauseUI.SetActive (false);
			Time.timeScale = 1;
		}
	}

	public void Exit (){
		Application.Quit();
	}
}
