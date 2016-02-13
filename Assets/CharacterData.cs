using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterData : MonoBehaviour {


	public List<InformationBase> infoOwned;

	public CharacterData(){
		this.infoOwned = new List<InformationBase> ();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
