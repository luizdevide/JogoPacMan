using UnityEngine;
using System.Collections;

public class scriptPacman : MonoBehaviour {

	private Rigidbody rbd;
	public float velocidade;
	public float velocidadeRot;
	private float rotY=0;
	private float rotX=0;

	void Start () {
		rbd = GetComponent<Rigidbody> ();
		velocidade = 10;
		velocidadeRot = 200;
		Cursor.lockState = CursorLockMode.Locked;
	}

	void Update () {
		float z = Input.GetAxis ("Vertical");
		float x = Input.GetAxis ("Horizontal");
		rotY += Input.GetAxis ("Mouse X") * velocidadeRot * Time.deltaTime;
		rotX += Input.GetAxis ("Mouse Y") * velocidadeRot * Time.deltaTime;
		rbd.velocity = transform.TransformDirection(new Vector3 (x* velocidade,z* velocidade));
		if(Input.GetKeyDown(KeyCode.Space))
			rbd.AddForce (0,200,0);
		transform.localEulerAngles = new Vector3(0,rotY,0);
		Camera.main.transform.localEulerAngles = new Vector3 (Mathf.Clamp(rotX,-70,70),0,0);
	}
}
