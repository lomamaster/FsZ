using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desstroybycontract : MonoBehaviour 
{
	//public GameObject Player1;
	public GameObject explosion;
	public GameObject playerexplosion;
	private Gamecontroller gameController;
	//public bool losslife = false;
	public int Blood=0;
	void Start()
	{

	}
		
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Boundary") || other.CompareTag ("Enemy") || other.CompareTag ("crate")) 
		{
			return;
		}

		if (explosion != null) 
		{
			Instantiate (explosion, transform.position, transform.rotation);
		}

		if (other.tag == "Player") 
		{
			/*
			if (other.GetComponent<PlayerController> ().immortal == false) 
			{
				
				//Instantiate (playerexplosion, other.transform.position, other.transform.rotation);

				//gameController.GameOver ();
				//Destroy (other.gameObject);

			}
			*/
		}
		else 
		{
			Destroy (other.gameObject);
		}

		Destroy (gameObject);
	}

	
}
