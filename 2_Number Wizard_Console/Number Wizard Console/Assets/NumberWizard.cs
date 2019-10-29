using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		int min = 1;
		int max = 1000;

		Debug.Log("Welcome to Number Wizard");
		Debug.Log("Pick a number, don't tell me what it is ...");
		Debug.Log("Lowest number is: " + min);
		Debug.Log("Highest number is: " + max);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
