using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InterviewScript : MonoBehaviour {

	public GameObject lindsaybuckets;
	public void Start()
	{
		InitializeInterview (lindsaybuckets);

	}

	public GameObject gwen;
	public GameObject infoblockprefab;
	public GameObject choicePane;

	void InitializeInterview(GameObject interviewee){
		Debug.Log ("Interview Initialized. Interviewee is " + interviewee);
		this.gameObject.SetActive (true);
		GameObject[] characters = GameObject.FindGameObjectsWithTag ("Character");
		List<InformationBase> gwenIntel = gwen.GetComponent<CharacterData> ().infoOwned;
		List<InformationBase> otherIntel = interviewee.GetComponent<CharacterData> ().infoOwned;

		foreach (InformationBase intel in gwenIntel)
		{
			//instantiate an infoblock
			GameObject newBlock = (GameObject)Instantiate(infoblockprefab);
			newBlock.transform.SetParent(GameObject.Find("Gwens Infoblock Cache").transform);

		}
		foreach (InformationBase intel in otherIntel)
		{
			//instantiate an infoblock
			GameObject newBlock = (GameObject)Instantiate(infoblockprefab);
			newBlock.transform.parent = GameObject.Find("NPCs Infoblock Cache").transform;
		}
	}

	public void Tap(GameObject block){
		//adds infoblock to the center pane, along with choice items 
		GameObject newPane = (GameObject)Instantiate (choicePane);
		newPane.transform.SetParent(GameObject.Find("Dynamic Block Selection").transform);
		}

	public void Untap(InfoBlock block){
		// if a currently tapped infoblock is clicked, untap it, kill the panel.
	}
}
