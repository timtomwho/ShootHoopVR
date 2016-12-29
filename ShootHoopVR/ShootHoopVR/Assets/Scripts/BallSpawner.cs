using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 randomVector = new Vector3
            (ballPrefab.transform.position.x + Random.Range(-1f,1f),
            ballPrefab.transform.position.y,
            ballPrefab.transform.position.z + Random.Range(-1f, 1f));

        if (Input.GetKeyDown(KeyCode.Space))Instantiate(ballPrefab, randomVector,Quaternion.identity);
	}
}
