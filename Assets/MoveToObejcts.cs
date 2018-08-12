using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObejcts : MonoBehaviour {

    public float speed;
    public Transform[] ways;

    private bool isRunning;

    private void Start()
    {
        StartCoroutine(Move());
        isRunning = true;
    }

    private IEnumerator Move()
    {
        foreach (Transform way in ways)
        {
            yield return StartCoroutine(MoveToPoint(way));
        }

        isRunning = false;
    }

    private IEnumerator MoveToPoint(Transform point)
    {
        while (!point.GetComponent<changeColorOnTrigger>().hasCollidedWithBox)
        {
            transform.position = Vector3.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
            yield return null;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isRunning)
            {
                StopAllCoroutines();
                isRunning = false;
            }
            else
            {
                isRunning = true;
                StartCoroutine(Move());
            }
        }
    }
}
