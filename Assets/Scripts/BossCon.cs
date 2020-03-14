﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossCon : MonoBehaviour {

	public GameObject explosion;
	private int life=0;

	void OnTriggerEnter (Collider other){
		life = life + 1;
        if (life == 50)  
		{
            Debug.Log(life);
            GameObject.Find("GameController").GetComponent<Gamecontroller>().NextScene = true;
           // Invoke("Gotonext", 3);
            Destroy (this.gameObject);
            //SceneManager.LoadScene("main2", LoadSceneMode.Single);
        }
			


	if(other.CompareTag ("Boundary") || other.CompareTag ("Enemy"))

	{
		return;
	}
		if (explosion !=null)
		{
			Instantiate(explosion , transform.position,transform.rotation);
		}
		Destroy(other.gameObject);
}
   // void Gotonext()
   //{
       // SceneManager.LoadScene("main2", LoadSceneMode.Single);

   // }
}