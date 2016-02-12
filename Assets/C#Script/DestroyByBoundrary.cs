using UnityEngine;
using System.Collections;

public class DestroyByBoundrary : MonoBehaviour {

	void OnTriggerExit (Collider other) 
	{
		Destroy(other.gameObject);
	}
}
