using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveLeftAndRight : MonoBehaviour
{
    public float speed = .05f;

    private float xPosition;
    private float yPosition;
    private float zPosition;

    private bool moveRight = true;

    // private Rigidbody2D rb2D;

    void Start() {
        xPosition = gameObject.transform.position.x;
        yPosition = gameObject.transform.position.y;
        zPosition = gameObject.transform.position.z;
    }

    void Update() {
        Debug.Log("Updating");

        if (moveRight)
        {
            Debug.Log("Moving right");
            if (gameObject.transform.position.x >= 7.8f)
            {
                moveRight = false;
            }
            else
            {
                gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
        }
        else if (!moveRight)
        {
            Debug.Log("Moving left");
            if (gameObject.transform.position.x <= -8f)
            {
                moveRight = true;
            }
            else
            {
                gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }

    }
}
