using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int saved = 0;	
	public int health = 5;						// The player's health.
	public float repeatDamagePeriod = 2f;		// How frequently the player can be damaged.

	public float hurtForce = 10f;				// The force with which the player is pushed when hurt.
	public int damageAmount = 1;				// The amount of damage to take when enemies touch the player
	private float lastHitTime;					// The time at which the player was last hit.

void OnCollisionEnter2D (Collision2D col)
	{
		// If the colliding gameobject is an Enemy...
		if(col.gameObject.tag == "ENEMYOUCH")
		{
			//float direction = Mathf.Sign(transform.position.x - col.transform.position.x);
			rigidbody2D.velocity = new Vector2(0.0f, 0.0f);
			rigidbody2D.AddForce(new Vector2(0, 300));
			
			// ... and if the time exceeds the time of the last hit plus the time between hits...
			if (Time.time > lastHitTime + repeatDamagePeriod) 
			{
				// ... and if the player still has health...
				if(health > 0)
				{
					// ... take damage and reset the lastHitTime.
					
					lastHitTime = Time.time; 

					// Reduce the player's health by 10.
					health -= damageAmount;
				}
				
	}
   }
}
  
  

	  
  
}
