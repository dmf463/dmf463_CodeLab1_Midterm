using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMangerScript : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    public Text player1HealthUI;
    public Text player2HealthUI;

    TextMesh gameOver;

	// Use this for initialization
	void Start () {

        player1 = GameObject.Find("Player");
        player2 = GameObject.Find("Player2");
        gameOver = GetComponent<TextMesh>();
        gameOver.characterSize = 0;	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("CharacterSelectSreen");
        }

        if (player1 == null)
        {
            player1HealthUI.text = "0";
            gameOver.characterSize = 1;
        }
        if (player2 == null)
        {
            player2HealthUI.text = "0";
            gameOver.characterSize = 1;
        }
        player1HealthUI.text = player1.GetComponent<PlayerControlScript>().PlayerHealth.ToString();
        player2HealthUI.text = player2.GetComponent<PlayerControlScript>().PlayerHealth.ToString();

    }
}
