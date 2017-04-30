using UnityEngine;
using System.Collections;

public class PlayerLife : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Collectable")
		{
			
			Destroy(other.gameObject);
			CollectionAndScore.Score += 1;
			
		}
		if(other.tag == "Target")
		{
			
			Destroy(other.gameObject);
			CollectionAndScore.Lives -= 1;
			
		}
	}
}
