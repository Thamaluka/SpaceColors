using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public Button Play;
	public Button Exit;

	public void PlayGame(){
		SceneManager.LoadScene (1);
	}

}
