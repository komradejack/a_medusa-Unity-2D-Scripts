using UnityEngine;
using System.Collections;

public class enemyStoned : MonoBehaviour {

	public bool eyeOpen = false;	
	public bool chatPlayer = true;
	public GameObject stonedEnemy;
	public int stoneCount = 0;
	public AudioClip playerPass;

	// Use this for initialization
	void Start () {
	
	}
	
	
	// Update is called once per frame 
	void Update ()
	{
		// If the fire button is pressed...
		if(Input.GetButtonDown("Fire1"))
			{
			Debug.Log("Fire was hit");
			eyeOpen = false;
			}
		if(Input.GetButtonUp("Fire1"))
			{
			eyeOpen = true;	
		
			//audio.Play();
			}
	}
	
	void OnTriggerEnter2D (Collider2D col) 
	{
		// If it is hit by the eyebeam
		if(col.tag == "EYE" && (eyeOpen == true))
		{
			 print( "Destroy enemy object" );
			
			 Destroy(gameObject);
			 Instantiate(stonedEnemy, transform.position,transform.rotation);
		}
		// If it is hit by the player
		if(col.tag == "Player" && chatPlayer == true)
		{
			 print( "Player Pass by" );
			 //AudioSource.PlayClipAtPoint(playerPass, transform.position);
			 audio.PlayOneShot(playerPass,1.0f);
			 //disable the sound from triggering until player leaves enemy
			 chatPlayer = false;
		}
		
	
		}
		void OnTriggerExit2D (Collider2D col)
					{
		
						// If the player leaves
						if(col.tag == "Player" && chatPlayer == false)
						{
						print( "Player Left" );
						//enable the sound
						chatPlayer = true;
						}
					}
}
