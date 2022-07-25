using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    private GroundSpawnController spawnController;
    private Rigidbody rb;
    [SerializeField] private float EndYValue;
    private int groundDirection;

    private void Start()
    {
        spawnController = FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        CheckGroundYPosition();
    }

    private void CheckGroundYPosition()
    {
        if(transform.position.y <= EndYValue)
        {
            setRigidBodyValues();
            setGroundNewPosition();


        }
    }
    private void setGroundNewPosition()
    {
        groundDirection = Random.Range(0, 2);
        if (groundDirection == 0)
        {
            transform.position = new Vector3(spawnController.lastGroundObject.transform.position.x - 1f,
                                             spawnController.lastGroundObject.transform.position.y,
                                             spawnController.lastGroundObject.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(spawnController.lastGroundObject.transform.position.x,
                                             spawnController.lastGroundObject.transform.position.y,
                                             spawnController.lastGroundObject.transform.position.z + 1f);
        }

        spawnController.lastGroundObject = gameObject;
    }

    private void setRigidBodyValues()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
