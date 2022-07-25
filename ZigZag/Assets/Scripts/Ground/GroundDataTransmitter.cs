using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] private GroundFallController GroundFallController;



    public void SetGroundRigidBodyValue()
    {
        StartCoroutine(GroundFallController.SetRigidBodyValues());
    } 
}
