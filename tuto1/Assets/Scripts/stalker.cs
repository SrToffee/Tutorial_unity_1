using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stalker : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        offset = new Vector3(0, 6, -8);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
