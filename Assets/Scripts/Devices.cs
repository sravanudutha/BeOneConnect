﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Devices : MonoBehaviour
{

    [SerializeField] GameObject DevicesScrollview;
    [SerializeField] GameObject profilepanel;
    [SerializeField] GameObject profilebar;

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

    public void Start()
    {

        Screen.fullScreen = false;
        profilepanel.SetActive(false);
        profilebar.SetActive(false);

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !(profilepanel.activeInHierarchy == true) )
        {
            // profilepanel.SetActive(false);
           
            SceneManager.LoadScene("SignIn");
            
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && (profilepanel.activeInHierarchy == true))
        {

            SceneManager.LoadScene("Devices");
        }
        
      

       
    } 

    public void Armablebtn()
    {
        SceneManager.LoadScene("Dashboard");
    }

    public void profilebtn()
    {
       
        profilepanel.SetActive(true);
        profilebar.SetActive(true);
        DevicesScrollview.SetActive(false);

       

    }


    public void backbtn()
    {
        SceneManager.LoadScene("Devices");
    }

    public void Homebtn()
    {
        DevicesScrollview.SetActive(true);

        profilepanel.SetActive(false);
       
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







}
