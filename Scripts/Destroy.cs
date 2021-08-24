using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
	{
	if(col.gameObject.name == "GameButtonUp")
	{
	Destroy(col.gameObject);
	}else if(col.gameObject.name =="GameButtonDown")
	{
	Destroy(col.gameObject);
	}else if(col.gameObject.name =="GameButtonLeft")
	{
	Destroy(col.gameObject);
	}else if(col.gameObject.name =="GameButtonRight")
	{
	Destroy(col.gameObject);
	}
	}
}
