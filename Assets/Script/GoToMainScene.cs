using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Button
using UnityEngine.SceneManagement; 

public class GoToMainScene : MonoBehaviour
{
    public int sceneIndex; //要載入的Scene
    
    void Start()
    {

    }

    // Detects if any key has been pressed.
    void Update()
    {
        if (Input.anyKey)
        {
            Debug.Log("A key or mouse click has been detected");
            SceneManager.LoadScene (1);
        }
    }
}