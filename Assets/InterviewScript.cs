using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InterviewScript : MonoBehaviour {

	public GameObject lindsaybuckets;
	public GameObject gwen;
	public GameObject infoblockprefab;
	public GameObject choicePane;

	public void Start()
	{
		InitializeInterview (lindsaybuckets);

	}



	void InitializeInterview(GameObject interviewee){
		//Debug.Log ("Interview Initialized. Interviewee is " + interviewee);
		//GameObject[] characters = GameObject.FindGameObjectsWithTag ("Character");
		List<InformationBase> gwenIntel = gwen.GetComponent<CharacterData> ().infoOwned;
		List<InformationBase> otherIntel = interviewee.GetComponent<CharacterData> ().infoOwned;
		//Debug.Log (otherIntel.Count);
		foreach (InformationBase intel in gwenIntel)
		{
			//instantiate an infoblock
			GameObject newBlock = (GameObject)Instantiate(infoblockprefab);
			newBlock.transform.SetParent(GameObject.Find("Gwens Infoblock Cache").transform);
			newBlock.GetComponent<RectTransform>().localScale = new Vector3(1,1,1);

		}
		Debug.Log ("Done with Gwen. Now the next one.");
		foreach (InformationBase intel in otherIntel)
		{
			//Debug.Log (otherIntel.Count);
			//instantiate an infoblock
			GameObject newBlock = (GameObject)Instantiate(infoblockprefab);
			newBlock.transform.SetParent(GameObject.Find("NPCs InfoBlock Cache").transform);
			newBlock.GetComponent<RectTransform>().localScale = new Vector3(1,1,1);
			Debug.Log ("Success");
		}
	}
}
