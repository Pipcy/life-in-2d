using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Routine : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    HealthBar health;
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;

        GameObject healthh =  GameObject.Find("Health System");
        health = healthh.GetComponent<HealthBar>();
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
        cam1.enabled = true;
        cam2.enabled = false;
    }

    public void WakeUp()
    {
        cam1.enabled = false;
        cam2.enabled = true;

        health.ResetHealth();
    }
}
