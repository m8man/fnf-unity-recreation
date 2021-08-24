﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

public bool canBePressed;
public AudioSource missSound;
public KeyCode keyToPress;
public GameObject hitEffect, goodEffect, perfectEffect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
		{
		if(canBePressed)
		{
		gameObject.SetActive(false);
	
		//GameManager.instance.NoteHit();
		
		if(Mathf.Abs( transform.position.y) > 8.30f)
		{
		Debug.Log ("Normal");
		GameManager.instance.NormalHit();
		Instantiate(hitEffect, transform.position, hitEffect.transform.rotation);
		missSound.Play();
		}else if(Mathf.Abs(transform.position.y) > 8.35)
		{
		Debug.Log ("Good");
		GameManager.instance.GoodHit();
		Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
		}else
		{
		Debug.Log("Perfect");
		GameManager.instance.PerfectHit();
		Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
		}
		}
		}
    }
	
	private void OnTriggerEnter2D(Collider2D other) 
	{
	if (other.tag == "Activator")
	{
	canBePressed = true;
	}
	}
	
	private void OnTriggerExit2D(Collider2D other) 
	{
	if (other.tag == "Activator")
	{
	canBePressed = false;
	
	GameManager.instance.NoteMissed();
	}
	}
	}
