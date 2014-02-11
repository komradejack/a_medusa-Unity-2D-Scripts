using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {


	public float health = 100f;					// The player's health.
	public float repeatDamagePeriod = 2f;		// How frequently the player can be damaged.
	public AudioClip[] ouchClips;				// Array of clips to play when the player is damaged.
	public float hurtForce = 10f;				// The force with which the player is pushed when hurt.
	public float damageAmount = 10f;			// The amount of damage to take when enemies touch the player
	
	private float lastHitTime;					// The time at which the player was last hit.
	

	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D (Collision2D col)
	{
		// If the colliding gameobject is an Enemy...
		if(col.gameObject.tag == "ENEMYOUCH")
		{
			// ... and if the time exceeds the time of the last hit plus the time between hits...
			if (Time.time > lastHitTime + repeatDamagePeriod) 
			{
				// ... and if the player still has health...
				if(health > 0f)
				{
					// ... take damage and reset the lastHitTime.
					TakeDamage(col.transform); 
					lastHitTime = Time.time; 
				}
				// If the player doesn't have health, do some stuff, let him fall into the river to reload the level.
				else
				{
					// Find all of the colliders on the gameobject and set them all to be triggers.
					Collider2D[] cols = GetComponents<Collider2D>();
					foreach(Collider2D c in cols)
					{
						c.isTrigger = true;
					}

					// Move all sprite parts of the player to the front
					SpriteRenderer[] spr = GetComponentsInChildren<SpriteRenderer>();
					foreach(SpriteRenderer s in spr)
					{
						s.sortingLayerName = "UI";
					}

					// ... disable user Player Control script
					//GetComponent<PlayerControl>().enabled = false;

					// ... disable the Gun script to stop a dead guy shooting a nonexistant bazooka
					//GetComponentInChildren<Gun>().enabled = false;

					// ... Trigger the 'Die' animation state
					//anim.SetTrigger("Die");
				}
			}
		}
	}
	
		void TakeDamage (Transform enemy)
	{
		// Make sure the player can't jump.
		//playerControl.jump = false;

		// Create a vector that's from the enemy to the player with an upwards boost.
		Vector3 hurtVector = transform.position - enemy.position + Vector3.up * 5f;

		// Add a force to the player in the direction of the vector and multiply by the hurtForce.
		rigidbody2D.AddForce(hurtVector * 10f);

		// Reduce the player's health by 10.
		health -= damageAmount;

		// Update what the health bar looks like.
		//UpdateHealthBar();

		// Play a random clip of the player getting hurt.
		//int i = Random.Range (0, ouchClips.Length);
		//AudioSource.PlayClipAtPoint(ouchClips[i], transform.position);
	}
	
	
	
	
	
	
	
	
	
}
