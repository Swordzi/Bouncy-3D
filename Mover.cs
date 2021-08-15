using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{
  [SerializeField] float moveSpeed = 6f;
    int direction = 3;
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
   void PrintInstructions()
    {
        Debug.Log("Welcome to Bouncy 3D");
        Debug.Log("Use WASD or arrow keys to move");
        Debug.Log("Avoid the walls, good luck!");       



    }
   void MovePlayer()
    {
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }



}
