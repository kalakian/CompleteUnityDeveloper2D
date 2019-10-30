using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
	int min;
	int max;
	int guess;

	// Start is called before the first frame update
	void Start()
    {
		Debug.Log("Welcome to Number Wizard");
		StartGame();
	}

	void StartGame()
	{
		min = 1;
		max = 1000;

		Debug.Log("Pick a number from " + min + " to " + max + ", don't tell me what it is ...");
		NextGuess();
		Debug.Log("Push Up = higher, Push Down = lower, Enter = correct");
		max++;
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log(guess + " was correct");
			StartGame();
		}
	}

	void NextGuess()
	{
		guess = (max + min) / 2;
		Debug.Log("Is it higher or lower than " + guess + "?");
	}
}
