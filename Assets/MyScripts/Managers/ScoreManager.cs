using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
	public class ScoreManager : MonoBehaviour
	{
		public static int score;        // The player's score.
	
		
		Text text;                      // Reference to the Text component.
		
		
		void Awake ()
		{
			// Set up the reference.
			text = GetComponent <Text> ();
			
			// Reset the score.
			score = 0;
			text.text = "Time Card Pieces: " + score;
		}
		// this is for another place
		//ScoreManager.score += scoreValue;
		void Update ()
		{
			// Set the displayed text to be the word "Score" followed by the score value.
			text.text = "Time Card Pieces: " + score;
		}

		/*void OnCollisionEnter (Collision other)
		{
			if (other.gameObject.tag == "timecard")        
			{            
				score = score + 1;
				text.text = "Time Card Pieces: " + score;
				print ("counting");
			} 
		} */
	}
}