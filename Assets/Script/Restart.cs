using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
 public void RestartGame() 
 {
     SceneManager.LoadScene(1);
 }

 //儲存背景音樂的AudioSource Component
    private AudioSource bgMusicAudioSource;
    
    void OnEnable()
    {
		//在所有Game Object中找尋Background Music
        bgMusicAudioSource = GameObject.FindGameObjectWithTag("Background Music").GetComponent<AudioSource> ();
        
		//音樂停止
        bgMusicAudioSource.Stop ();    
    }

    void OnDisable() 
    {
        //音樂播放
        bgMusicAudioSource.Play ();
    }
}
