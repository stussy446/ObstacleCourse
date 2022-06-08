using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeToWait = 3;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToWait)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
