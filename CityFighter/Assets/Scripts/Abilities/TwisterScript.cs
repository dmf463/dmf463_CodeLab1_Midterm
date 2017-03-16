using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwisterScript : MonoBehaviour {

    public float timer;
    public float returnTrigger;
    bool isComingBack = false;

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Twister")
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        if (timer > returnTrigger && isComingBack == false)
        {
            isComingBack = true;
            Debug.Log("COME BACK TO MEEE!!");
            GetComponent<Rigidbody>().velocity *= -1;
        }


		
	}
}
