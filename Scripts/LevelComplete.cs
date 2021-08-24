using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
public KeyCode seeToPress;


   void Update() 
   {
      if(Input.GetKeyDown(seeToPress))
		 {
		 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		 }
	 
   }
}