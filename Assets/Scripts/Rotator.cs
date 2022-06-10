using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    Transform tform;
    [SerializeField] float yRotationSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        tform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, yRotationSpeed * Time.deltaTime, 0);
    }
}
