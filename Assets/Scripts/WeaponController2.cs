using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController2 : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public Transform shotSpawn2;
	public Transform shotSpawn3;
	public Transform shotSpawn4;
	public Transform shotSpawn5;
	public Transform shotSpawn6;
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
		Instantiate (shot, shotSpawn2.position, shotSpawn2.rotation);
		Instantiate (shot, shotSpawn3.position, shotSpawn3.rotation);
		Instantiate (shot, shotSpawn4.position, shotSpawn4.rotation);
		Instantiate (shot, shotSpawn5.position, shotSpawn5.rotation);
		Instantiate (shot, shotSpawn6.position, shotSpawn6.rotation);
		audioSource.Play ();
	}
}
