using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bottons : MonoBehaviour {
	public int idBotton;
	public gameController gameControler;

	void OnMouseDown(){
		if(gameControler.gameState == GameState.RESPONDER){
			gameControler.StartCoroutine ("responder", idBotton);
	}
}

}