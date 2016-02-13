using UnityEngine;
using System.Collections;

public class InfoBlock : MonoBehaviour {


	string	label;
	string	mouseOver;
	bool	visible; 
	// Use this for initialization
	void Start (string label, string mouseOver, bool visible) {
		this.label = label;
		this.mouseOver = mouseOver;
		this.visible = visible;
	}
}
