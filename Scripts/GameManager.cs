using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

public AudioSource theMusic;
public float maxHealth = 100;
public float currentHealth;


public bool startPlaying;

public BeatScroller theBS;

public static GameManager instance;

public int currentScore;
public int scorePerNote = 100;
public int scorePerGoodNote = 150;
public int scorePerPerfectNote = 200;
public int scorePerMiss = 100;

public Text scoreText;



    // Start is called before the first frame update
    void Start()
    {
        instance = this;
		
		scoreText.text = "Score: 0";
		
	
		
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
		{
		if(Input.anyKeyDown) 
		{
		startPlaying = true;
		theBS.hasStarted = true;
		
		theMusic.Play();
		}
	    }
	
	    if(currentHealth < -999)
	    {
	    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	    }
    }
	public void NoteHit()
	{
	Debug.Log("Sick");
	scoreText.text = "Score: " + currentScore;
	currentHealth = currentScore;
	}
	public void NormalHit()
	{
	currentScore += scorePerNote;

	NoteHit();
	}
	
	public void GoodHit()
	{
	currentScore += scorePerGoodNote;
	
	NoteHit();
	}
	
	public void PerfectHit()
	{
	currentScore += scorePerPerfectNote;
	
	NoteHit();
	}
	
	
	
	public void NoteMissed()
	{
	Debug.Log("shit");
	currentScore -= scorePerMiss;

	}
}