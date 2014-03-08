using UnityEngine;
using System.Collections;

public class eyeC : MonoBehaviour
{
	public GameObject stonedEnemy;
	public bool eyeOpen = true;				



	void Awake()
	{
	//eyeOpen = true;	
	}
	void OnTriggerEnter2D (Collider2D col) 
	{
		// If it hits an enemy...
		if(col.tag == "ENEMY" && (eyeOpen == true))
		{
			 print( "ENEMY is STONED" );
			 
			 Instantiate(stonedEnemy, transform.position,transform.rotation);
		}
		}

	void Update ()
	{
		// If the fire button is pressed...
		if(Input.GetButtonUp("Horizontal"))
			{
			Debug.Log("Horizontal was hit");
			eyeOpen = false;
			renderer.enabled = false;
			//collider2D.enabled = false;
			}
		if(Input.GetButtonDown("Horizontal"))
			{
			eyeOpen = true;	
			renderer.enabled = true;
			//collider2D.enabled = true;
			//audio.Play();
			}
	}
	}
