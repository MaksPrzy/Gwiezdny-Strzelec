using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
	public float lifetime;
	void Start ()
	{
		Destroy (gameObject, lifetime);             //USUWAMY SKOPIOWANE KOMENDY KTÓRE POJAWIAJA SIE PO ZRODZENIU KAŻDEJ ASTEROIDY Z KOLEI JAK I TEJ ZNISZCZONEJ ZEBY BYŁ POŻĄDEK W TABELI HIERARCHY!
	}

}
