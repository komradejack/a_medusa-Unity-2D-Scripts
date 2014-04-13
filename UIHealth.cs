using UnityEngine;
using System.Collections;

public class UIHealth : MonoBehaviour {

	public Health characterHealth;
	//public GameObject characterHealth;
	//public health = GameObject.Find("character").GetComponent<Health>();


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
		//
		guiText.text = characterHealth.health.ToString();

	}
}
