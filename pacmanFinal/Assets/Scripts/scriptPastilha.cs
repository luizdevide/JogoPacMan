using UnityEngine;
using System.Collections;

public class scriptPastilha : MonoBehaviour {

	private static scriptJogo script;

	// Use this for initialization
	void Start () {
		if(script == null)
			script = GameObject.Find ("controladorJogo").GetComponent<scriptJogo>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter(Collision collision){

		if (collision.gameObject.tag == "Player") {
			Destroy (this.gameObject);
			script.incrementaScore ();
		}
	}
}
