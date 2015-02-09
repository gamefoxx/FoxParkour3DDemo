using UnityEngine;
using System.Collections;

public class Rebounce : MonoBehaviour {
	
	public float reBoundForce = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider co)
	{
		if (co.tag == "Player")
		{
			if (co.rigidbody)
			{
				co.GetComponent<PlayerControls>().playerState = PlayerControls.PlayerState.noControl;
				co.rigidbody.velocity = transform.forward * reBoundForce;
			}
		}
	}
}
