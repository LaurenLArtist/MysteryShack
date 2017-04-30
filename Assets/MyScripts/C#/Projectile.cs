using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour 
{
	public float ProjectileSpeed;
	public GameObject ExplosionPrefab;


	// Use this for initialization
	void Start () 
	{
	
	}
	void Update ()
	{
		float amtToMove = ProjectileSpeed * Time.deltaTime;
		transform.Translate (Vector3.up * amtToMove);
	}


	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Target")
		{
			Destroy(gameObject);
			Destroy(other.gameObject);
			Instantiate(ExplosionPrefab, transform.position, transform.rotation);
			
		}
		if(other.tag == "StaticObject")
		{
			Destroy(gameObject);
			Instantiate(ExplosionPrefab, transform.position, transform.rotation);
			
		}
	}
}
