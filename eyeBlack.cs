using UnityEngine;
using System.Collections;

public class eyeBlack : MonoBehaviour
{
			



	void Awake()
	{
		
	}
	
	void Update ()
	{
		// If the fire button is pressed...
		if(Input.GetButtonDown("Fire1"))
			{
			Debug.Log("Black was turned off");
			
			renderer.enabled = true;
			}
		if(Input.GetButtonUp("Fire1"))
			{
				
			renderer.enabled = false;
			//audio.Play();
			}
	}
	}
