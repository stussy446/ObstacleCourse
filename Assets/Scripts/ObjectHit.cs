using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer mesh;
    Color startingColor;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        startingColor = mesh.material.color;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameObject.tag != "hit")
        {
            mesh = GetComponent<MeshRenderer>();
            mesh.material.color = Color.green;
            gameObject.tag = "hit";
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        mesh = GetComponent<MeshRenderer>();
        mesh.material.color = startingColor;

    }

}
