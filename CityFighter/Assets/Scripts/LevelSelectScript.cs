using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelectScript : MonoBehaviour {

    PowerLevelScripts pl;
    private const string WEATHER_FIGHTER = "WeatherFighter";
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
        SceneManager.LoadScene(WEATHER_FIGHTER);
    }
    public void EifellTower()
    {
        pl.levelNames.Add("EifellTower.txt");
        SceneManager.LoadScene(WEATHER_FIGHTER);
    }
    public void Florida()
    {
        pl.levelNames.Add("Florida.txt");
        SceneManager.LoadScene(WEATHER_FIGHTER);
    }
}
