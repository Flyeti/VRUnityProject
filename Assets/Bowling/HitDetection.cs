using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour
{
    private void OnCollisionExit(Collision other)
    {
        Debug.Log("Hit.");
    }
}
