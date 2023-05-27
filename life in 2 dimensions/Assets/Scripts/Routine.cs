using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Routine : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;


    public AudioSource dreamAudio;
    public AudioSource realityAudio;

    public bool isDreaming = true;

    HealthBar health;
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;

        GameObject healthh =  GameObject.Find("Health System");
        health = healthh.GetComponent<HealthBar>();
    
        dreamAudio = GetComponent<AudioSource>();
        realityAudio = GetComponent<AudioSource>();

        realityAudio.Play();
        realityAudio.Pause();
        dreamAudio.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
         cam1.enabled = !cam1.enabled;
         cam2.enabled = !cam2.enabled;
        }

        if (Input.GetKeyDown(KeyCode.B)) {
            Dream();
        }

        // if (Input.GetKeyDown(KeyCode.M)) {
        //     WakeUp();
        // }
    }

    public void Dream()
    {
        isDreaming = true;

        cam1.enabled = true;
        cam2.enabled = false;
        
        realityAudio.Pause();
        dreamAudio.Play();
    }

    public void WakeUp()
    {
        isDreaming = false;

        cam1.enabled = false;
        cam2.enabled = true;

        health.ResetHealth();
        dreamAudio.Pause();
        realityAudio.Play();
    }
}




