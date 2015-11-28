using UnityEngine;
using System.Collections;

public class FungusCallScript : MonoBehaviour {
	// Use this for initialization
	public GameObject UIGrid;
	void Start () {
	
	}

	public void FungusTestCall()
	{
		Debug.Log ("Method successfully called from Fungus.");
		UIGrid.SetActive (true);
	}

	public void ReturnToFungus()
	{
		UIGrid.SetActive (false);
		Fungus.Flowchart.BroadcastFungusMessage ("TestBLOCK2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
