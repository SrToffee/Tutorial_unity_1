using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnspeed;
    public float horizontalInput;

    public float forwardInput;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //move forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * speed);
    }
}
