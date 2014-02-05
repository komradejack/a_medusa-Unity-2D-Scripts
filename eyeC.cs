﻿using UnityEngine;
using System.Collections;

public class eyeC : MonoBehaviour
{
	
	public bool eyeOpen = true;				



	void Awake()
	{
	
	}
	void OnTriggerEnter2D (Collider2D col) 
	{
		// If it hits an enemy...
		if(col.tag == "ENEMY" && (eyeOpen == true))
		{
			 print( "ENEMY is STONED" );
		}
		}

	void Update ()
	{
		// If the fire button is pressed...
		if(Input.GetButtonDown("Fire1"))
			{
			Debug.Log("Fire was hit");
			eyeOpen = true;
			renderer.enabled = true;
			}
		if(Input.GetButtonUp("Fire1"))
			{
			eyeOpen = false;	
			renderer.enabled = false;
			//audio.Play();
			}
	}
	}