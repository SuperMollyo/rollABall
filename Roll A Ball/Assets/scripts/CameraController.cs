using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start() 
	{
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate runs every frame like Update but is 
	//guaranteed to run after all items have been processed and updated.
	void LateUpdate() 
	{
		transform.position = player.transform.position + offset;
	}
}
