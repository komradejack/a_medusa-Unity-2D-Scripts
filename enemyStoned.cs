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
		if(Input.GetButtonDown("Horizontal"))
			{
			Debug.Log("eyeOpen = true");
			eyeOpen = true;
			}
		if(Input.GetButtonUp("Horizontal"))
			{
			Debug.Log("eyeOpen = false");
			eyeOpen = false;	
		
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
