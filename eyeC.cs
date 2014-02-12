using UnityEngine;
using System.Collections;

public class eyeC : MonoBehaviour
{
	public GameObject stonedEnemy;
	public bool eyeOpen = true;				



	void Awake()
	{
	eyeOpen = true;	
	}
	void OnTriggerEnter2D (Collider2D col) 
	{
		// If it hits an enemy...
		if(col.tag == "ENEMY" && (eyeOpen == true))
		{
			 print( "ENEMY is STONED" );
			 
			 //Instantiate(stonedEnemy, transform.position,transform.rotation);
		}
		}

	void Update ()
	{
		// If the fire button is pressed...
		if(Input.GetButtonDown("Fire1"))
			{
			Debug.Log("Fire was hit");
			eyeOpen = false;
			renderer.enabled = false;
			}
		if(Input.GetButtonUp("Fire1"))
			{
			eyeOpen = true;	
			renderer.enabled = true;
			//audio.Play();
			}
	}
	}
