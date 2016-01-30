using UnityEngine;
using System.Collections;

public class GhostTransferScript : MonoBehaviour {

	public GameObject ghost;
	public GameObject gwen;
	public GameObject otherChar;
	public GameObject targetLocation;

	public float moveSpeed = 10f;
	public bool isMoving = false;

	void Start(){
		StartAnimation (otherChar, gwen);
		Debug.Log (otherChar.transform.localPosition + "   " + gwen.transform.localPosition);
		Debug.Log (ghost.transform.localPosition);
	}

	void Update(){
		if (isMoving == true) {
			TransferAnimation(targetLocation);
		}
	}

	public void StartAnimation(GameObject startPoint, GameObject endPoint){
		Debug.Log ("StartAnimation Called.");
		ghost.transform.position = startPoint.transform.position;
		targetLocation = endPoint; //set destination
		isMoving = true;
		ghost.transform.LookAt (targetLocation.transform.position); //face the target destination

	}

	public void TransferAnimation(GameObject ghostTarget){

		if (ghostTarget == otherChar) {				//when we're moving towards the other character
			if (ghost.transform.localPosition.x >= ghostTarget.transform.localPosition.x) { //check to see if we should stop
				isMoving = false;
				Debug.Log ("isMoving set false.");
			} 
			else {       //if we don't need to stop, keep going.
				//ghost.transform.LookAt (ghostTarget.transform.position); //face the target destination
				ghost.transform.Translate (ghost.transform.forward * moveSpeed * Time.deltaTime);	
			}
		}
		else {		//we're going towards Gwen
			if (ghost.transform.localPosition.x <= ghostTarget.transform.localPosition.x) { //check to see if we should stop
				isMoving = false;
				Debug.Log("isMoving set false.");
			} 
			else {       //if we don't need to stop, keep going.
				//ghost.transform.LookAt(ghostTarget.transform.position); //face the target destination
				ghost.transform.Translate (ghost.transform.forward * moveSpeed * Time.deltaTime);	
			}
		}



	}
}
