using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}

	public void botao(){
		SceneManager.LoadScene (1);

	}
}
