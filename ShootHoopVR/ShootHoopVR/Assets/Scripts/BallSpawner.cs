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
            GameObject ballInstance = Instantiate(ballPrefab) as GameObject;
            Rigidbody rb = ballInstance.GetComponent<Rigidbody>();
            rb.velocity += Vector3.forward * ballSpeed;
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            GameObject ballInstance = Instantiate(ballPrefab) as GameObject;
            Rigidbody rb = ballInstance.GetComponent<Rigidbody>();
            rb.velocity += Vector3.left * ballSpeed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject ballInstance = Instantiate(ballPrefab) as GameObject;
            Rigidbody rb = ballInstance.GetComponent<Rigidbody>();
            rb.velocity += Vector3.back * ballSpeed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject ballInstance = Instantiate(ballPrefab) as GameObject;
            Rigidbody rb = ballInstance.GetComponent<Rigidbody>();
            rb.velocity += Vector3.right * ballSpeed;
        }
	}
}
