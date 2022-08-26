using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour {

	private Vector3 cameraTarget;

	private Transform target;
	public float followSpeed = 5;
	
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void FixedUpdate () {
		cameraTarget = new Vector3(target.position.x,transform.position.y,target.position.z);
		transform.position = Vector3.Lerp(transform.position,cameraTarget,Time.deltaTime * followSpeed);
	}
}
