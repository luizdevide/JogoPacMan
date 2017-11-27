using UnityEngine;
using System.Collections;

public class scriptPacman : MonoBehaviour {

	private Rigidbody rbd;
	public float velocidade;
	public float velocidadeRot;
	private float rotY=0;

	void Start () {
		rbd = GetComponent<Rigidbody> ();
		velocidade = 50;
		velocidadeRot = 100;
		Cursor.lockState = CursorLockMode.Locked;
	}

	void Update () {
		float z = Input.GetAxis ("Vertical");
		float x = Input.GetAxis ("Horizontal");
		rotY += Input.GetAxis ("Mouse X") * velocidadeRot * Time.deltaTime;
		rbd.velocity = transform.TransformDirection(new Vector3 (x* velocidade,0,z* velocidade));
		transform.localEulerAngles = new Vector3(0,rotY,0);
		Camera.main.transform.localEulerAngles = new Vector3 (Mathf.Clamp(0,-70,70),0,0);
	}
		
}
