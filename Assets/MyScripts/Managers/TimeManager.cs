using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
	public class TimeManager : MonoBehaviour
	{
		public static int score;        // The player's score.
		public Timer count;
		
		Text text;                      // Reference to the Text component.
		
		
		void Awake ()
		{
			// Set up the reference.
			text = GetComponent <Text> ();
			
			// Reset the score.
			score = 0;
		}
		// this is for another place
		//ScoreManager.score += scoreValue;
		void Update ()
		{
			// Set the displayed text to be the word "Score" followed by the score value.
			text.text = "Time Left: " + count.timer;
		}
	}
}

