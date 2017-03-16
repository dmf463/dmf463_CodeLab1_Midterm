using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningScript : ProjectileSpawner {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //if (transform.parent.localScale.x == (-1))
        //{
        //    speed *= -1;
        //}

        //transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        transform.localScale += new Vector3 (2, 0, 0) * speed * Time.deltaTime;

    }

    public override float firingSpeed()
    {
        float firingSpeed = 1;
        return firingSpeed;
    }
}
