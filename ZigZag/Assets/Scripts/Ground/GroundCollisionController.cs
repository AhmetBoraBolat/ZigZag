using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] GroundDataTransmitter GroundDataTransmitter;
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GroundDataTransmitter.SetGroundRigidBodyValue();
        }
    }
}
