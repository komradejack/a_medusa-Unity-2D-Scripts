using UnityEngine;
using System.Collections;

public class enemyStoned : MonoBehaviour {

	public bool eyeOpen = false;	
	public GameObject stonedEnemy;

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
			eyeOpen = true;
			}
		if(Input.GetButtonUp("Fire1"))
			{
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
}
