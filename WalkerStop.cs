using UnityEngine;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class WalkerStop : MonoBehaviour
{
	// 1 - Designer variables
	
	/// <summary>
	/// Object speed
	/// </summary>
	public Vector2 speed = new Vector2(1, 1);
	public int interval = 1;
	
	/// <summary>
	/// Moving direction
	/// </summary>
	public Vector2 direction = new Vector2(-1, 0);
	
	private Vector2 movement;
	
	void Update()
	{
		// 2 - Movement
		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
	}
	
	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
		
	}
	
	void OnCollisionEnter2D (Collision2D col)
	{
		// If the colliding gameobject is an Obstacle...
		if(col.gameObject.tag == "Player")
		{
			print("Destroy enemy object due to NME+Player collision" );
			Destroy(gameObject);
		}
		// If the colliding gameobject is an Obstacle...
		if(col.gameObject.tag == "EYE")
		{
			print("Destroy enemy object due to NME+Player collision" );
			Destroy(gameObject);
		}


		
		
	}
	void OnTriggerEnter2D (Collider2D col) 
	{
		// If it hits an enemy...
		if(col.tag == "ObstacleStop")
		{
			print( "ENEMY is Stopped" );
			
			speed = new Vector2(0, 0);
		}
	}
}