using UnityEngine;
using System.Collections;

public class Footstep_Player : MonoBehaviour {

	public AudioClip playerFootstep;
	public float footVol = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void footStep ()
	{
	audio.PlayOneShot(playerFootstep,footVol);
	}
	
	
}
