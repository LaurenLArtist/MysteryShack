using UnityEngine;
using System.Collections;

public class Boundry : MonoBehaviour 
{

	//destroys the bullet if it leaves the play space
	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject);
	}
}
