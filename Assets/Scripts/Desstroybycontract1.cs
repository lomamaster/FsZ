using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desstroybycontract1 : MonoBehaviour 
{
	public GameObject explosion;
	public GameObject playerexplosion;
	private Gamecontroller gameController;
	void Start()
	{

	}
		
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Boundary") || other.CompareTag ("Enemy")|| other.CompareTag("crate"))
			
		{
			return;
		}
		if (explosion !=null)
		{
			Instantiate(explosion , transform.position,transform.rotation);
		}
		if(other.tag=="Player"){
		Instantiate(playerexplosion , other.transform.position,other.transform.rotation);
			//gameController.GameOver ();
		}

			Destroy(other.gameObject);
		Destroy(gameObject);
	}


}
