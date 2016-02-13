using UnityEngine;
using System.Collections;

public class InformationBase : ScriptableObject {
	string title;
	string description;
	string mouseOver;

	void Start(){
	}
	// Use this for initialization
	public InformationBase (string title, string description, string mouseOver) {
		this.title = title;
		this.description = description;
		this.mouseOver = mouseOver;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
