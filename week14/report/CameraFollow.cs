using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(ball.transform.position.x + 3,
        ball.transform.position.y + 3,
        ball.transform.position.z - 14);
    }
}