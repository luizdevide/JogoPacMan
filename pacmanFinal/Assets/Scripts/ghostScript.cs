using UnityEngine;
using System.Collections;

public class ghostScript : MonoBehaviour {

	public GameObject target;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		if (target == null) {
			target = GameObject.FindGameObjectWithTag ("Player");

		}
	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = target.transform.position;
	}

	public void OnCollisionEnter(Collision collision){
		
	}
}
