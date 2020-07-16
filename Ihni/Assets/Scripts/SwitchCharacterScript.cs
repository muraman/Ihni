using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacterScript : MonoBehaviour {

	// referenses to controlled game objects
	public GameObject character1, character2;

	// variable contains which avatar is on and active
	int whichCharacterIsOn = 1;

	// Use this for initialization
	void Start() 
	{
		// Enable first character and disable another one
		character1.gameObject.SetActive(true);
		character2.gameObject.SetActive(false);
	}



	// public method to switch characters by pressing button
	public void SwitchCharacter()
	{

		// processing whichCharacterIsOn variable
		switch (whichCharacterIsOn) 
		{

		// if the first character is on
		case 1:

			// then the second character is on now
			whichCharacterIsOn = 2;

			// disable the first one and anable the second one
			character1.gameObject.SetActive(false);
			character2.gameObject.SetActive(true);

			//tp one character to another
			character2.gameObject.transform.position = character1.gameObject.transform.position;

			break;

		// if the second character is on
		case 2:

			// then the first character is on now
			whichCharacterIsOn = 1;

			// disable the second one and enable the first one
			character1.gameObject.SetActive(true);
			character2.gameObject.SetActive(false);

			//tp one character to another
			character1.gameObject.transform.position = character2.gameObject.transform.position;

			break;
		}
			
	}

	void Update() 
	{
		if (Input.GetButtonDown("Switch")) 
		{	
			SwitchCharacter();
		}

	}
}
