using UnityEngine;
using System.Collections;

public class CollectionAndScore : MonoBehaviour 
{
	public static int Score = 0;
	public static int Lives = 3;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnGUI()
	{
		GUI.Label (new Rect(10, 10, 60, 20), "Score: " + CollectionAndScore.Score.ToString());
		GUI.Label (new Rect(10, 30, 60, 20), "Lives: " + CollectionAndScore.Lives.ToString());
	}
}
