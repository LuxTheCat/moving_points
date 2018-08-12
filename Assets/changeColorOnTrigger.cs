using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColorOnTrigger : MonoBehaviour {

    [SerializeField]
    private Renderer rend;
    public bool hasCollidedWithBox;

	// Use this for initialization
	void Start () {
        hasCollidedWithBox = false;
        rend = GetComponent<Renderer>();
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasCollidedWithBox = true;
            rend.material.color = Color.green;
        }
    }
}
