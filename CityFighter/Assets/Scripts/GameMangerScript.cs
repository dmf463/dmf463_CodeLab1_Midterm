using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMangerScript : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    public Text player1HealthUI;
    public Text player2HealthUI;

	// Use this for initialization
	void Start () {

        player1 = GameObject.Find("Player");
        player2 = GameObject.Find("Player2");

		
	}
	
	// Update is called once per frame
	void Update () {

        player1HealthUI.text = player1.GetComponent<PlayerControlScript>().PlayerHealth.ToString();
        player2HealthUI.text = player2.GetComponent<PlayerControlScript>().PlayerHealth.ToString();

    }
}
