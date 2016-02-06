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
	}

	void Update(){
		if (isMoving == true) {
			TransferAnimation(targetLocation);
		}
	}

	public void StartAnimation(GameObject startPoint, GameObject endPoint){
		ghost.transform.localPosition = startPoint.transform.localPosition;
		targetLocation = endPoint; //set destination
		isMoving = true;
	}

	public void TransferAnimation(GameObject ghostTarget){

		if (ghostTarget == otherChar) {				//when we're moving towards the other character
			if (ghost.transform.localPosition.x >= ghostTarget.transform.localPosition.x) { //check to see if we should stop
				isMoving = false;
				Debug.Log ("isMoving set false.");
			} 
			else {       //if we don't need to stop, keep going.
				ghost.transform.Translate (new Vector3(1,0,0) * moveSpeed * Time.deltaTime);	
				GhostFader();
			}
		}
		else {		//we're going towards Gwen
			if (ghost.transform.localPosition.x <= ghostTarget.transform.localPosition.x) { //check to see if we should stop
				isMoving = false;
				Debug.Log("isMoving set false.");
			} 
			else {       //if we don't need to stop, keep going.
				ghost.transform.Translate (new Vector3(-1,0,0) * moveSpeed * Time.deltaTime);	
				GhostFader();
			}
		}
	}

	public void GhostFader() //visual for fading the ghost transfer in and out
	{
		float absolute = Mathf.Abs (ghost.transform.localPosition.x);
		ghost.GetComponent<CanvasGroup> ().alpha = Mathf.Lerp (1,0, (absolute/350));
	}
}
