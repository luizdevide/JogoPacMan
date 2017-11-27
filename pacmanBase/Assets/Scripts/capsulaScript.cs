using UnityEngine;
using System.Collections;

public class capsulaScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Player") {
			Destroy (this.gameObject);
		}
	}
		
}
