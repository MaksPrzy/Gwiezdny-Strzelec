using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
	private Rigidbody rb;
	public float tumble;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * tumble;                   //angularVelocity to nic innego jak ustawienie z jaka prędkościa ma sie obracac dany obiekt//
	}
}

