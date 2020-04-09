using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFoodOrefab : MonoBehaviour
{
    public GameObject eatCakeAudioEffect;
    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.name == "FoodPrefab")
            Instantiate (eatCakeAudioEffect); 
    }
            
}
