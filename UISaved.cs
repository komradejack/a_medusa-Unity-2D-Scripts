using UnityEngine;
using System.Collections;

	public class UISaved : MonoBehaviour {
	
	public Health characterSaved;

	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//
		guiText.text = characterSaved.saved.ToString();
		
	}
}
