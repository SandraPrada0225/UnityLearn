using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repearRate = 2;
    private PlayerController playerControllerScript;
    private float leftBound = 15;

    // Start is called before the first frame update
    void Start()
    {
      playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
      InvokeRepeating("SpawnObstacle", startDelay, repearRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        //si la variable gameOver de playerController es verdadera, se dejan de generan obstaculos
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

        //si la posicion de un obstaculo es menor, se destruye
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
