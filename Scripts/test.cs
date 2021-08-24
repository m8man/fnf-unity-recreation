using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class test : MonoBehaviour {



    public bool canBePressed;



    public KeyCode keyToPress;



    public GameObject normaleffect, goodefect, perfectmate;



    // Start is called before the first frame update

    void Start()

    {

        

    }



    // Update is called once per frame

    void Update()

    {

        if(Input.GetKeyUp(keyToPress))

        {

            if(canBePressed)

            {

                gameObject.SetActive(false);



                //GameManager.instance.NoteHit();



                if(Mathf.Abs( transform.position.y) > 8.30f)

                {

                    Debug.Log("beuh");

                    GameManager.instance.NormalHit();

                    Instantiate(normaleffect, transform.position, normaleffect.transform.rotation);

                } else if(Mathf.Abs(transform.position.y) > 8.35)

                {

                    Debug.Log("good");

                    GameManager.instance.GoodHit();

                    Instantiate(goodefect, transform.position, goodefect.transform.rotation);

                } else

                {

                    Debug.Log("perfect");

                    GameManager.instance.PerfectHit();

                    Instantiate(perfectmate, transform.position, perfectmate.transform.rotation);

                }

            }

        }

    }



    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.tag == "LongAct")

        {

            canBePressed = true;

        }



    }



    private void OnTriggerExit2D(Collider2D other)

    {

        if (other.tag == "LongAct" && gameObject.activeSelf)

        {

            canBePressed = false;

    

            GameManager.instance.NoteMissed();

        

        }

    }

}
