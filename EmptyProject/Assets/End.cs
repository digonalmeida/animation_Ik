using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {
	public GameObject vincent;
	Vector3 startPoint;
	void Start(){
		startPoint=vincent.transform.position;
	}
	void Update(){
		float d=Vector3.Distance(vincent.transform.position,transform.position);
		if(Vector3.Distance(vincent.transform.position,transform.position)<3){
			vincent.transform.position=startPoint;
		}
	}

}
