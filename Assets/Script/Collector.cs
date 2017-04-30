using UnityEngine;
using System.Collections;


public class Collector : MonoBehaviour 
{
	public float collected = 0.0f;
	public bool unlocked = false;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnCollisionEnter (Collision other)
	{ 
		if (other.gameObject.tag == "timecard")        
		{            
			Destroy (other.gameObject);
			collected = collected + 1;
			print ("hit");
		} 
		if (other.gameObject.name == "Door")
		{
			if (collected >= 3)
			{
				Destroy (other.gameObject);
				unlocked = false;

			}
		}
	}
}
