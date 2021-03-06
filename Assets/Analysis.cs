﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Analysis : MonoBehaviour
{

    public bool statusBar;
    public AndroidStatusBar.States states = AndroidStatusBar.States.Visible;

    void Awake()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            AndroidStatusBar.dimmed = !statusBar;
            AndroidStatusBar.statusBarState = states;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Screen.fullScreen = false;
    }


    public void Testyourselfbtn()
    {
        SceneManager.LoadScene("TestYourselfscene");
    }

    public void MessagePanelbtn()
    {
        SceneManager.LoadScene("Message_1");
    }

    public void NotificationPanelbtn()
    {
        SceneManager.LoadScene("Notfication");
    }

    public void HomePanelbtn()
    {
        SceneManager.LoadScene("Devices");
    }

    public void Analysisbtn()
    {
        SceneManager.LoadScene("Analysis");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // profilepanel.SetActive(false);

            SceneManager.LoadScene("Devices");

        }
    }
}
