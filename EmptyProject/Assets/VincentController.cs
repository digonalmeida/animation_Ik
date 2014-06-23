using UnityEngine;
using System.Collections;

public class VincentController : MonoBehaviour {
	public float speed=1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 tempPosition= transform.position;
		tempPosition.z+=speed*Time.deltaTime;
		transform.position=tempPosition;
	}


}
