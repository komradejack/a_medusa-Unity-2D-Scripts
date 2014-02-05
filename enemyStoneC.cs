using UnityEngine;
using System.Collections;

public class enemyStoneC : MonoBehaviour {


void OnTriggerEnter2D (Collider2D col) 
	{
		// If it hits an enemy...
		if(col.tag == "ENEMY" )
		{
			 print( "Collided with ENEMY" );
		}
		}
		
		}