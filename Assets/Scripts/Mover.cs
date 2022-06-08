using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();   
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

    }

    // prints out instructions of the game onto the console 
    private void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");

    }

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, 0, zValue);
    }
}
