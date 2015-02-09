using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision co)
	{
		GameObject ob = co.gameObject;
		
		Debug.Log(ob);
		if (ob.tag == "Player")
		{
			ob.GetComponent<PlayerControls>().playerState = PlayerControls.PlayerState.normal;
			ob.rigidbody.velocity = Vector3.zero;
		}
	}
}