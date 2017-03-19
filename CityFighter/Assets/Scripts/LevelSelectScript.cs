using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelectScript : MonoBehaviour {

    PowerLevelScripts pl;

	// Use this for initialization
	void Start () {

        pl = GameObject.Find("PlayerPowerLevels").GetComponent<PowerLevelScripts>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TestLevel()
    {
        pl.levelNames.Add("testLevel.txt");
        SceneManager.LoadScene("WeatherFighter");

    }
}
