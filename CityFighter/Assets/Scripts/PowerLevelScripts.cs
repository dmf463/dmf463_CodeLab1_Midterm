using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PowerLevelScripts : MonoBehaviour {

    public List<float> PlayerPowerLevels;
    public List<string> PlayerAbilities;

    public static PowerLevelScripts instance;

	// Use this for initialization
	void Start () {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }

        PlayerPowerLevels = new List<float>();
        PlayerAbilities = new List<string>();
	}
	
	// Update is called once per frame
	void Update () {

        DontDestroyOnLoad(this);
		
	}
}
