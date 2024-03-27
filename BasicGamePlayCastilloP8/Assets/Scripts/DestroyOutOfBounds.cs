using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 35;
    private float lowerBound = -15;
    private float sideBound = 30;

    private NewBehaviourScript gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<NewBehaviourScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the player view in the game, remove that
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound) { Debug.Log("Game Over"); gameManager.AddLives(-1); Destroy(gameObject); }
        else if (transform.position.x > sideBound) { Debug.Log("Game Over"); gameManager.AddLives(-1); Destroy(gameObject); }
        else if (transform.position.x < -sideBound)
        {
            Debug.Log("Game Over"); gameManager.AddLives(-1); Destroy(gameObject);
        }
    }
}
