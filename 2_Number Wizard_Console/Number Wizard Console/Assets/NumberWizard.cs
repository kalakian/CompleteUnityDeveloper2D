using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
	int min = 1;
	int max = 1000;
	int guess = 500;

	// Start is called before the first frame update
	void Start()
    {
		Debug.Log("Welcome to Number Wizard");
		Debug.Log("Pick a number, don't tell me what it is ...");
		Debug.Log("Lowest number is: " + min);
		Debug.Log("Highest number is: " + max);
		Debug.Log("Tell me if your number is higher or lower than " + guess);
		Debug.Log("Push Up = higher, Push Down = lower, Enter = correct");
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			Debug.Log("You pressed the up arrow");
			min = guess;
			Debug.Log(guess);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Debug.Log("You pressed the down arrow");
			max = guess;
			Debug.Log(guess);
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("You pressed the enter key");
		}
	}
}
