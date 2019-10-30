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
		Debug.Log("Pick a number from " + min + " to " + max + ", don't tell me what it is ...");
		Debug.Log("Tell me if your number is higher or lower than " + guess);
		Debug.Log("Push Up = higher, Push Down = lower, Enter = correct");
		max++;
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			guess = (max + min) / 2;
			Debug.Log("Higher ... how about " + guess + "?");
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			guess = (max + min) / 2;
			Debug.Log("Lower ... how about " + guess + "?");
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log(guess + " was correct");
		}
	}
}
