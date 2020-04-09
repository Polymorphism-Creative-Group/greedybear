using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Bear : MonoBehaviour {
    // Current Movement Direction
    // (by default it moves to the down)
    Vector2 dir = Vector2.down;
    
// Use this for initialization
    void Start() {
    // Move the Bear every 3000ms
    InvokeRepeating("Move", 0.3f, 0.3f);
    }

// Update is called once per frame
    void Update() {
        // Move in a new Direction?
        if (Input.GetKey(KeyCode.RightArrow))
            //dir = Vector2.right;
            {
                transform.rotation = Quaternion.Euler(Vector3.forward * 90);
            }
        else if (Input.GetKey(KeyCode.DownArrow))
            //dir = -Vector2.up; // '-up' means 'down'
            {
            transform.rotation = Quaternion.Euler(Vector3.zero);
            }
        else if (Input.GetKey(KeyCode.LeftArrow))
            //dir = -Vector2.right; // '-right' means 'left'
            {
            transform.rotation = Quaternion.Euler(Vector3.forward * 270);
            }
        else if (Input.GetKey(KeyCode.UpArrow))
            //dir = Vector2.up;
            {
            transform.rotation = Quaternion.Euler(Vector3.forward * 180);
            }
    }
    // Keep Track of Tail
List<Transform> tail = new List<Transform>();
    
    // Did the snake eat something?
bool ate = false;

    // Tail Prefab
    public GameObject tailPrefab;
    public GameObject canvasPrefab;

    void Move () {
        // Save current position (gap will be here)
        Vector2 v = transform.position;
        // Move head into new direction (now there is a gap)
        transform.Translate (dir);
        
        // Ate something? Then insert new Element into gap
        if (ate) {
            // Load Prefab into the world
            GameObject g = (GameObject) Instantiate (tailPrefab, v, Quaternion.identity);

            // Keep track of it in our tail list
            tail.Insert (0, g.transform);

            // Reset the flag
            ate = false;

        }
        // Do we have a Tail?
        else if (tail.Count > 0) {
            // Move last Tail Element to where the Head was
            tail.Last ().position = v;

            // Add to front of list, remove from the back
            tail.Insert (0, tail.Last ());
            tail.RemoveAt (tail.Count - 1);
        }
    }
    public GameObject eatCakeAudioEffect;
    public GameObject gameOverAudioEffect;
    void OnTriggerEnter2D (Collider2D coll) {
        // Food?
        if (coll.name.StartsWith ("FoodPrefab")) {
            // Get longer in next Move call
            ate = true;

            // Remove the Food
            Destroy (coll.gameObject);
            ScoreCode.Score = ScoreCode.Score + 1;
            Instantiate (eatCakeAudioEffect);
        }
        // Collided with Tail or Border
        else if (coll.name.StartsWith ("TailPrefab") || coll.name.StartsWith ("Border")) {
            // ToDo 'You lose' screen
            
            Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);
            //Debug.Log ("GAME OVER!");
            foreach (var t in tail) {
                Destroy (t.gameObject);
            }
            tail.Clear ();
            transform.position = new Vector2 (0, 0);
            Instantiate (gameOverAudioEffect);
            //ScoreCode.Score = 0;
        }
    }
}
    

