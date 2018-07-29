﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirtyDishBehavior : MonoBehaviour {
    public GameObject manager;
    public ManagerController managerControllerScript;
    public int dishCount = 1;
    public AudioClip dishSound;
    public AudioSource soundSource;

    // Use this for initialization
    void Start () {
        gameObject.SetActive(true);
        managerControllerScript = manager.GetComponent<ManagerController>();
        soundSource.clip = dishSound;
    }

    private void OnMouseDown()
    {
        soundSource.Play();
        managerControllerScript.earnedAllowance = (managerControllerScript.earnedAllowance + dishCount);
        managerControllerScript.rLevelExp = managerControllerScript.rLevelExp + .2f;
        Debug.Log(managerControllerScript.earnedAllowance);
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "dish")
        {
            Destroy(gameObject);
        }

    }
}
