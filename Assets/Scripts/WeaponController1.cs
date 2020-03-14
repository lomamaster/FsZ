using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController1 : MonoBehaviour {

	public GameObject shot;
	public GameObject shot2;
	public Transform shotSpawn;
	public Transform shotSpawn2;
	public float fireRate;
	public float delay;
	private AudioSource audioSource;



	void Start () 
	{
		audioSource = GetComponent<AudioSource> ();
		InvokeRepeating ("Fire",delay,fireRate);
	}

	void Fire ()
	{
		Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		Instantiate (shot2, shotSpawn2.position, shotSpawn2.rotation);
		audioSource.Play ();
	}
}
