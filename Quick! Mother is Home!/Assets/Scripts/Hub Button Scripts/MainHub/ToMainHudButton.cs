﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMainHudButton : MonoBehaviour {

    public GameObject manager;
    public ManagerController managerControllerScript;
    public AudioClip buttonPushedSound;
    public AudioSource soundEffectSource;

    private void Start()
    {
        soundEffectSource.clip = buttonPushedSound;
        managerControllerScript = manager.GetComponent<ManagerController>();
    }

    private void Update()
    {
        CheckForPopups();
    }

    void OnMouseDown()
    {
        soundEffectSource.Play();
        managerControllerScript.showEmpireHud = false;
        managerControllerScript.showChoreUpgradeHud = false;
        managerControllerScript.showToolUpgradeHud = false;
        managerControllerScript.showMainHud = true;
    }

    private void CheckForPopups()
    {
        if (managerControllerScript.popupWindowOpen == true)
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
        else if (managerControllerScript.popupWindowOpen == false)
        {
            gameObject.GetComponent<Collider2D>().enabled = true;
        }
    }
}
