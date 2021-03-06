﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour {

    private float damage;
    public float Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    public GameObject projectilePrefab;
    public GameObject lightningPrefab;
    public GameObject sunPrefab;
    public GameObject windPrefab;
    public GameObject snowPrefab;
    //float firingSpeed;
    public GameObject player;
    public float projectilePosTuning;
    private float projectilePosX;
    private float projectilePosY;

    PowerLevelScripts pl;
    PlayerControlScript pc;

    // Use this for initialization
    void Start()
    {
        pl = GameObject.Find("PlayerPowerLevels").GetComponent<PowerLevelScripts>();
        pc = GetComponent<PlayerControlScript>();

        if (gameObject.name == "Player")
        {
            Damage = pl.PlayerPowerLevels[0];
            Debug.Log(gameObject.name + " does " + Damage + " damage!");

            if (pl.PlayerAbilities[0] == "Wind")
            {
                projectilePrefab = windPrefab;
            }
            if (pl.PlayerAbilities[0] == "Lightning")
            {
                projectilePrefab = lightningPrefab;
            }
            if (pl.PlayerAbilities[0] == "Sun")
            {
                projectilePrefab = sunPrefab;
            }
            if (pl.PlayerAbilities[0] == "Snow")
            {
                projectilePrefab = snowPrefab;
            }

        }

        if (gameObject.name == "Player2")
        {
            Damage = pl.PlayerPowerLevels[1];
            Debug.Log(gameObject.name + " does " + Damage + " damage!");

            if (pl.PlayerAbilities[1] == "Wind")
            {
                projectilePrefab = windPrefab;
            }
            if (pl.PlayerAbilities[1] == "Lightning")
            {
                projectilePrefab = lightningPrefab;
            }
            if (pl.PlayerAbilities[1] == "Sun")
            {
                projectilePrefab = sunPrefab;
            }
            if (pl.PlayerAbilities[1] == "Snow")
            {
                projectilePrefab = snowPrefab;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (pc.isRotated == true)
        {
            projectilePosX = (player.transform.position.x) - projectilePosTuning;
        }
        else
        {
            projectilePosX = (player.transform.position.x) + projectilePosTuning;
        }
        projectilePosY = player.transform.position.y;

    }

    public void shootProjectile()
    {
        Vector2 projectilePos = new Vector3(projectilePosX, projectilePosY);
        GameObject projectile = Instantiate(projectilePrefab, projectilePos, Quaternion.identity) as GameObject;
        //projectile.transform.parent = gameObject.transform;
        if (pc.isRotated == true)
        {
            projectile.GetComponent<Rigidbody>().velocity = new Vector3(-firingSpeed(), 0, 0);
            Debug.Log("Flipping!");
        }
        else
        {
            projectile.GetComponent<Rigidbody>().velocity = new Vector3(firingSpeed(), 0, 0);
        }
    }

    public virtual float firingSpeed()
    {
        float firingSpeed = 50;
        return firingSpeed;
    }
}
