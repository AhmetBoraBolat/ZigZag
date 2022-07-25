using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{

    [HideInInspector] public Vector3 BallDirection;

    void Start()
    {
        BallDirection = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        HandleBallInputs();
    }

    private void HandleBallInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChanngeBallDirection();
        }
    }

    private void ChanngeBallDirection()
    {
        if(BallDirection.x== -1)
        {
            BallDirection = Vector3.forward;
        }
        else
        {
            BallDirection = Vector3.left;
        }
    }

}
