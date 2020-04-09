using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToSceneOnClick : MonoBehaviour
{
    public int sceneIndex; //要載入的Scene
    
    void Start()
    {
		//為按鈕加入On Click事件
        GetComponent<Button> ().onClick.AddListener (() => {
            ClickEvent ();
        });
    }
    
    void ClickEvent()
    {
		//切換Scene
        SceneManager.LoadScene(1);
    }
}
