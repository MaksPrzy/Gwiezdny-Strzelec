﻿using System.Collections;
using UnityEngine;
using System.ComponentModel;

[System.Serializable]  // inaczej Hierarchia dziedziczenia.
public class Boundary  //Granica mapy
{
	public float xMin, xMax, zMin, zMax;
}
	
    public class PlayerController2 : MonoBehaviour
{
	private Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}
	public Boundary boundary;    //Granica mapy                                                                             OGARNAC ZEBY SKRZAŁY LECIA LY ZE STATKU A NIE ZE SRODKA!!!!
	public float tilt;
	public float speed;
	public float fireRate;

	private float nextFire;

	public GameObject shot;
	public Transform shotSpawn;   //shotSpawn.transform.position...........
	void Update ()
	{
		if (Input.GetButton ("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
	//		GameObject clone = 
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation); // as GameObject               //ustawiamy pozycje i poruszanie(strzału).
		}
			
	}


	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");                       // ustawienie poruszania sie pojazdu do przodu i do tylu
		float moveVertical = Input.GetAxis ("Vertical");                           // ustawienie poruszania sie pojazdu w prawo i lewo

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.velocity= movement * speed ;                                          // ustawienie poruszania sie pojazdu oraz jego prędkości

		rb.position = new Vector3 
		(
			Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax),           //wyznacznie granic mapy
			0.0f,
			Mathf.Clamp (rb.position.z, boundary.zMin, boundary.zMax)            //wyznacznie granic mapy
		);
			
		rb.rotation = Quaternion.Euler (rb.velocity.x, 0.0f, rb.velocity.x * tilt);
    }
}