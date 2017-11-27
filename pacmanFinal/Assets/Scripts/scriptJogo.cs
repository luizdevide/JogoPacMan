using UnityEngine.UI;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptJogo : MonoBehaviour {

	public GameObject pastilha;
	public Text score;
	private int score_int = 0;

	public void incrementaScore(){
		scriptPastilha script = pastilha.gameObject.GetComponent<scriptPastilha> ();
		score_int += 100;
		score.text = "Score = " + score_int;

		if (score_int >= 800) {
			SceneManager.LoadScene (3);
		}
	}

}
