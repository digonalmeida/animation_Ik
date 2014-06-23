using UnityEngine;
using System.Collections;

public class IKAgent : MonoBehaviour {
	public GameObject iklimbObject;
	public IKLimb iklimb;
	GameObject currentTarget;

	// Use this for initialization
	void Start () {
		iklimbObject.SendMessage("ClearTarget",SendMessageOptions.DontRequireReceiver);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		Debug.Log(other.name);
		if(other.tag=="Target"){
			currentTarget=other.gameObject;
			iklimbObject.SendMessage("SetTarget",currentTarget,SendMessageOptions.DontRequireReceiver);

		}
	}
	void OnTriggerExit(Collider other){
		if(currentTarget!=null){
			if(other.gameObject==currentTarget){
				iklimbObject.SendMessage("ClearTarget",SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
