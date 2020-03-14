using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodImplecount : MonoBehaviour {
	public GameObject Player;
	public GameObject playerExplosion;
	public int Wait;
	public int Blood=0;

    
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Enemy") && !this.GetComponent<PlayerController>().immortal) {
            
            this.GetComponent<PlayerController>().immortal = true;


            Instantiate (playerExplosion, this.transform.position, this.transform.rotation);
			
			//Invoke("Respawn",1);
			//	GetComponent<Desstroybycontract> ().losslife = false;
			//	if (other.GetComponent<PlayerController> ().immortal1 == false) {
			Blood++;
			if (Blood <= 2) {
				Vector3 spawnPosition = new Vector3 (0, 0, 0);
				//Quaternion spawnRotation = Quaternion.identity;

				//GameObject p = Instantiate (Player, spawnPosition, spawnRotation) as GameObject;
				this.transform.position = spawnPosition;
                this.GetComponent<PlayerController>().Change(0);

				Invoke ("BackToMortal", 2);
			} else {
				//Debug.Log (other.gameObject);

				GameObject.Find ("GameController").GetComponent<Gamecontroller> ().GameOver ();
				this.gameObject.SetActive (false);
			}
		}
	}
    

	void BackToMortal() {
		this.GetComponent<PlayerController> ().immortal = false;
	}

		//}
	//void Respawn(){
		//Respawn ();

			//Blood++;
			//if (Blood <= 2) {
				//Vector3 spawnPosition = new Vector3 (0, 0, 0);
				//Quaternion spawnRotation = Quaternion.identity;
				//Instantiate (Player, spawnPosition, spawnRotation);//
			//	GetComponent<Desstroybycontract> ().losslife = false;
			//} else {
			//	GetComponent<Desstroybycontract> ().losslife = false;
			//}
		//}//yield return new WaitForSeconds (Wait);

	//void Respawn()
	//{
		//if (Destroy=true) {
		//	transform.position = Vector3.zero;
		//	Destroy = false;
	//	}
	//}

	//}
}
