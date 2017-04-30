using UnityEngine;
using System.Collections;

public class TargetDestroy : MonoBehaviour 
{
	public GameObject ExplosionPrefab;

	// Use this for initialization

  void OnDestroy()
	{

		Instantiate(ExplosionPrefab, transform.position, transform.rotation);
		Debug.Log("POP");
	}

	/*	
	void OnTriggerEnter(Collider other)
	{ 

		if(other.tag == "Projectile")
		{

			Instantiate(ExplosionPrefab, transform.position, transform.rotation);
		}


	}
	*/

}

	