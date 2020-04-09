﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class InstantiateCanvasOnClick : MonoBehaviour {
    //要產生的canvas
    public GameObject canvasPrefab;
    
    void Start() {
        //按下按鈕時，呼叫ClickEvent()
        GetComponent<Button> ().onClick.AddListener (() => { ClickEvent (); });
    }

    void ClickEvent() {
		//生產canvasPrefab
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);
        AudioSource source = GameObject.FindGameObjectWithTag ("Background Music").GetComponent<AudioSource> ();
		source.Pause();
}
}
