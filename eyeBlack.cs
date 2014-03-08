using UnityEngine;
using System.Collections;

public class eyeBlack : MonoBehaviour
{
			



	void Awake()
	{
	renderer.enabled = true;
	//collider.enabled = true;
		
	}
	
	void Update ()
	{
		// If the fire button is pressed...
		if(Input.GetButtonDown("Horizontal")) 
			{
			Debug.Log("Black was turned on");
			renderer.enabled = false;
			//collider.enabled = false;
			}
		if(Input.GetButtonUp("Horizontal")) 
			{
			renderer.enabled = true;
			//collider.enabled = true;
			//audio.Play();
			}
	}
	}
