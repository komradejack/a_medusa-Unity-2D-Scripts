using UnityEngine;
using System.Collections;

public class stoneFloat : MonoBehaviour {

	public Vector2 speed = new Vector2(0, 0);
	private Vector2 movement;
	public Vector2 direction = new Vector2(0, 0);
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		{
			// 2 - Movement
			movement = new Vector2(
				speed.x * direction.x,
				speed.y * direction.y);
		}
	
	}

	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
		
	}
}
