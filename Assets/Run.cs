using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {

    public float speed;

    private float RandomDirection;

	void Start () {
        RandomDirection = Random.Range(0, 360);
        Debug.Log(RandomDirection);
        transform.Rotate(0, RandomDirection, 0, Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        RandomDirection = Random.Range(90, 270);
        transform.Rotate(0, RandomDirection, 0, Space.Self);
    }

    void Update () {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
}
