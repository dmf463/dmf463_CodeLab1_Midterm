using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PowerLevelScripts : MonoBehaviour {

    public List<float> PlayerPowerLevels;
    public List<string> PlayerAbilities;

	// Use this for initialization
	void Start () {

        PlayerPowerLevels = new List<float>();
        PlayerAbilities = new List<string>();
	}
	
	// Update is called once per frame
	void Update () {

        DontDestroyOnLoad(this);
		
	}
}
