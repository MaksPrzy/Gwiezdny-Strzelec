using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByBoundary : MonoBehaviour 
{
	void OnTriggerExit(Collider other)           //Niszczy nam w consoli zapysywany strzał (inaczej robi nam porzadek w tabeli Hierarchii!!!
	{
		Destroy (other.gameObject);                                               
	}
}
