using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;
    public int ballSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.W)) {
            
            SpawnBall().velocity += Vector3.forward * ballSpeed;
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            SpawnBall().velocity += Vector3.left * ballSpeed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnBall().velocity += Vector3.back * ballSpeed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            SpawnBall().velocity += Vector3.right * ballSpeed;
        }
        
	}

    Rigidbody SpawnBall()
    {
        GameObject ballInstance = Instantiate(ballPrefab) as GameObject;
        Rigidbody rb = ballInstance.GetComponent<Rigidbody>();
        return rb;
    }
}
