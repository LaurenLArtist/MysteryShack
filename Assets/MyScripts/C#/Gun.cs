using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	public GameObject ProjectilePrefab;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown("space"))//get key down means only the first frame activates
		{
			//Fire Projectile
			Instantiate(ProjectilePrefab, transform.position, transform.rotation);
		}
	
	}
}
