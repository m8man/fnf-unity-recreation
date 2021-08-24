using UnityEngine;
using UnityEngine.SceneManagement;

public class resetrage : MonoBehaviour
{ 

public KeyCode pepToPress;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pepToPress))
		 {
		 SceneManager.LoadScene("Menu2");
		 }
    }
}
