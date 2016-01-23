using UnityEngine;
using System.Collections;

public class buttontranslate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonTranslate()
	{
		Vector3 destination = this.gameObject.transform.position;
		destination.x = destination.x + 1;
		this.gameObject.transform.Translate (destination);
	}
}
