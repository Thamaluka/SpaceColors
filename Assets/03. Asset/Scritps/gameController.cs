using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
	SEQUENCIA,
	RESPONDER,
	NOVA,
	ERRO
}

public class gameController : MonoBehaviour {
	public GameState gameState;


	// Use this for initialization
	void Start () {
		StartCoroutine ("Responder");
	}
		
		
	// Update is called once per frame
	void Update () {
		
	}
}
