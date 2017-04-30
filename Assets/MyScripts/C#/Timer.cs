using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour 
{
	public float timer = 0f;
	public float delayTimer = 0.0f;
	public string present = null;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if (timer < delayTimer)
		{
			present = "Time Up";
		}
	}
}
