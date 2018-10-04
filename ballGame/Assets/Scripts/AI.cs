using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AI : MonoBehaviour {

    Vector3 pointA = new Vector3(-2f, 0, 7.5f);
    Vector3 pointB = new Vector3(0, 0, -7.5f);

    void Update()
    {
        float time = Mathf.PingPong(Time.time * .4f, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}