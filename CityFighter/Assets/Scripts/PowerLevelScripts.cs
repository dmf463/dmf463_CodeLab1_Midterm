using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class PowerLevelScripts : MonoBehaviour {

    public List<float> PlayerPowerLevels;
    public List<string> PlayerAbilities;

    public List<string> levelNames;

    public static PowerLevelScripts instance;

    public float offsetX = 0;
    public float offsetY = 0;

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
        levelNames = new List<string>();

        string fileName = levelNames[0];
        string filePath = Application.dataPath + "/Levels/" + fileName;

        StreamReader sr = new StreamReader(filePath);
        GameObject levelHolder = new GameObject("LevelHolder");

        int yPos = 0;

        GameObject player1 = Instantiate(Resources.Load("Prefabs/Player") as GameObject);
        GameObject player2 = Instantiate(Resources.Load("Prefabs/Player2") as GameObject);

        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            for(int xPos = 0; xPos < line.Length; xPos++)
            {
                if (line[xPos] == 'x')
                {
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.parent = levelHolder.transform;
                    cube.transform.position = new Vector3(
                        xPos + offsetX,
                        yPos + offsetY,
                        0);
                }
                if (line[xPos] == '1')
                {
                    player1.transform.position = new Vector3(
                        xPos + offsetX,
                        yPos + offsetY,
                        0);
                }
                if(line[xPos] == '2')
                {
                    player2.transform.position = new Vector3(
                        xPos + offsetX,
                        yPos + offsetY,
                        0);
                }
            }
        }

        yPos--;

        sr.Close();
	}
	
	// Update is called once per frame
	void Update () {

        DontDestroyOnLoad(this);
		
	}
}
