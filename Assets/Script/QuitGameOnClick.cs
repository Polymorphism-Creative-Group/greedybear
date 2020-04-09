using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuitGameOnClick : MonoBehaviour {
    
    void Start() {
    //按下按鈕後，呼叫ClickEvent()
        GetComponent<Button> ().onClick.AddListener (() => {ClickEvent (); });
    }
    
    void ClickEvent() {
    // Quit Game
        Application.Quit();
    }
}
