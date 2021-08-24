using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDFK : MonoBehaviour
{
public KeyCode whatKeyUp;
public KeyCode whatKeyDown;
public KeyCode whatKeyLeft;
public KeyCode whatKeyRight;
    [Header("Bool shit")]
    public bool IsIdle;
    public bool UpNode;
    public bool DownNode;
    public bool LeftNode;
    public bool RightNode;

    public bool IsWorking;

    [Header("sprites")]
    public GameObject IdleSprite;
    public GameObject UpSprite;
    public GameObject DownSprite;
    public GameObject LeftSprite;
    public GameObject RightSprite;

	


    [Header("values")]
    public float cooldown = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        IsIdle = true;
        UpNode = false;
        DownNode = false;
        RightNode = false;
        LeftNode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsIdle)
        {
            IdleSprite.SetActive(true);
            UpSprite.SetActive(false);
            DownSprite.SetActive(false);
            LeftSprite.SetActive(false);
            RightSprite.SetActive(false);
        }

        if(UpNode)
        {
            IdleSprite.SetActive(false);
            UpSprite.SetActive(true);
            DownSprite.SetActive(false);
            LeftSprite.SetActive(false);
            RightSprite.SetActive(false);
        }

        if(DownNode)
        {
            IdleSprite.SetActive(false);
            UpSprite.SetActive(false);
            DownSprite.SetActive(true);
            LeftSprite.SetActive(false);
            RightSprite.SetActive(false);
        }

        if(LeftNode)
        {
            IdleSprite.SetActive(false);
            UpSprite.SetActive(false);
            DownSprite.SetActive(false);
            LeftSprite.SetActive(true);
            RightSprite.SetActive(false);
        }

        if(RightNode)
        {
            IdleSprite.SetActive(false);
            UpSprite.SetActive(false);
            DownSprite.SetActive(false);
            LeftSprite.SetActive(false);
            RightSprite.SetActive(true);
        }




        

        if(IsWorking)
        {
            if(Input.GetKeyDown(whatKeyUp))
        {

            StartCoroutine(UpNod());
        }

        if(Input.GetKeyDown(whatKeyLeft))
        {

            StartCoroutine(LeftNod());
        }

        if(Input.GetKeyDown(whatKeyDown))
        {
     
            StartCoroutine(DownNod());
        }

        if(Input.GetKeyDown(whatKeyRight))
        {
       
            StartCoroutine(RightNod());
        }

        }

        
    }

    IEnumerator UpNod()
    {
        IsIdle = false;
        UpNode = true;
        DownNode = false;
        LeftNode = false;
        RightNode = false;
        IsWorking = false;
        yield return new WaitForSeconds(cooldown);
        IsIdle = true;
        UpNode = false;
        DownNode = false;
        LeftNode = false;
        RightNode = false;
        IsWorking = true;
    }

    IEnumerator DownNod()
    {
        IsIdle = false;
        UpNode = false;
        DownNode = true;
        LeftNode = false;
        RightNode = false;
        IsWorking = false;
        yield return new WaitForSeconds(cooldown);
        IsIdle = true;
        UpNode = false;
        DownNode = false;
        LeftNode = false;
        RightNode = false;
        IsWorking = true;
    }

    IEnumerator LeftNod()
    {
        IsIdle = false;
        UpNode = false;
        DownNode = false;
        LeftNode = true;
        RightNode = false;
        IsWorking = false;
        yield return new WaitForSeconds(cooldown);
        IsIdle = true;
        UpNode = false;
        DownNode = false;
        LeftNode = false;
        RightNode = false;
        IsWorking = true;
    }

    IEnumerator RightNod()
    {
        IsIdle = false;
        UpNode = false;
        DownNode = false;
        LeftNode = false;
        RightNode = true;
        IsWorking = false;
        yield return new WaitForSeconds(cooldown);
        IsIdle = true;
        UpNode = false;
        DownNode = false;
        LeftNode = false;
        RightNode = false;
        IsWorking = true;

    }

}