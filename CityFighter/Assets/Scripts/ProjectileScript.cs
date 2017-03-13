using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

    ProjectileSpawner projectileSpawner;
    PowerLevelScripts pl;

	// Use this for initialization
	void Start () {

        pl = GameObject.Find("PlayerPowerLevels").GetComponent<PowerLevelScripts>();

    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Floor")
        {
            if (this.gameObject.tag != "IceSpikes")
            {
                Destroy(this.gameObject);
            }
            else
            {
                var joint = gameObject.AddComponent<FixedJoint>();
                joint.connectedBody = other.rigidbody;
            }

        }

        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.name == "Player")
            {
                other.gameObject.GetComponent<PlayerControlScript>().playerHealth -= pl.PlayerPowerLevels[1];
                Destroy(gameObject);
                Debug.Log(other.gameObject.name + " has " + other.gameObject.GetComponent<PlayerControlScript>().playerHealth + " health!");
            }
            if (other.gameObject.name == "Player2")
            {
                other.gameObject.GetComponent<PlayerControlScript>().playerHealth -= pl.PlayerPowerLevels[0];
                Destroy(gameObject);
                Debug.Log(other.gameObject.name + " has " + other.gameObject.GetComponent<PlayerControlScript>().playerHealth + " health!");
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
