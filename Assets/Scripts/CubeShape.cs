using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class CubeShape : BaseShape
{
    // POLYMORPHISM
    protected override void MovingShape()
    {
        Speed = 200.0f;
        messageText += $"{nameof(MovingShape)} of {this.name} class\r\n";
        GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }
}
