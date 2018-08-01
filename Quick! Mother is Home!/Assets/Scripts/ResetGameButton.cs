﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGameButton : MonoBehaviour {
    public GameObject slider;
    public GameObject optionsTitle;
    public GameObject musicVolumeTitle;
    public GameObject checkTitle;
    public GameObject checkExplaination;
    public GameObject checkButton;
    public GameObject xConfirmButton;

    private void OnMouseDown()
    {
        slider.SetActive(false);
        optionsTitle.SetActive(false);
        musicVolumeTitle.SetActive(false);
        checkExplaination.SetActive(true);
        checkTitle.SetActive(true);
        checkButton.SetActive(true);
        xConfirmButton.SetActive(true);
        gameObject.SetActive(false);
    }
}
