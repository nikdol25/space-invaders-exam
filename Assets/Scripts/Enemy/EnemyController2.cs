using System.Collections;
using UnityEngine;

public class EnemyController2 : MonoBehaviour
{
    public float minPosX;
    public float maxPosX;

    public float moveDistance = 1f;
    public float timeStep = 2f;

    bool isMovingRight = false;

    // Use this for initialization
    void Start()
    {
        // Invoke repeating will be called once after timeStep (2nd parameter) amount,
        // and then repeatedly every timeStep (3rd parameter) amount
        InvokeRepeating("Move", timeStep, timeStep);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Move()
    {
        if (isMovingRight)
        {
            // Moving right
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos + new Vector3(moveDistance, 0f);
            transform.position = newPos;

            // If aliens group reached the right-most edge, flip their direction
            if (transform.position.x >= maxPosX)
            {
                isMovingRight = false;
            }
        }
        else
        {
            // Moving left
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos - new Vector3(moveDistance, 0f);
            transform.position = newPos;

            // If aliens group reached the left-most edge, flip their direction
            if (transform.position.x <= minPosX)
            {
                isMovingRight = true;
            }
        }
    }
}

