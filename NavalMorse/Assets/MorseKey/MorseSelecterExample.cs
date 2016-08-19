using UnityEngine;
using System.Collections;

public class MorseSelecterExample : MonoBehaviour, IMorseEventHandler {
	public string morseSentence;

	public void KeyInput (char input) {
		print ("My name is:" + this + " I got: " + input);
	}
	public void SentenceInput(string sentence) {
		print ("My name is:" + this + " I got sentence " + sentence);
	}

}
