using UnityEngine;
using System.Collections;

public class ThrustersControl : MonoBehaviour 
{
	public ParticleSystem myParticles;

	//int maxParticles = 3;


	void Start ()
	{

	}


	// Update is called once per frame
	void FixedUpdate () 
	{
		if(Input.GetAxis("Vertical") > 0.0f)

		{

			myParticles.Play();
		}

		else
		{

			myParticles.Stop();
		} 
	
	}
	void Update ()
	{
		//Debug.Log(Input.GetAxis ("Vertical"));
	}
}

/* {
  if(Input.GetAxis("Vertical") > 0.0f)
	if(Input.GetKey(KeyCode.W))
	{
		myParticles.Play();
	}
	else
	if(Input.GetAxis("Vertical") < 0.01f)
	{
		//myParticles.Stop();
	}
}

		if(Input.GetAxis("Vertical") > 0.0f)
			myParticles.particleCount =Input.GetAxis ("Vertical") * maxParticles;
			*/
			