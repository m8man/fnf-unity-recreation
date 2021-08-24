﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedStartScript : MonoBehaviour
{

public GameObject countDown;
public AudioSource aSound; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine ("StartDelay");
		aSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
 
 }

IEnumerator StartDelay(){

Time.timeScale = 0;
float pauseTime = Time.realtimeSinceStartup + 3;
while (Time.realtimeSinceStartup < pauseTime)
yield return 0;
countDown.gameObject.SetActive(false); 
Time.timeScale = 1;
}

}