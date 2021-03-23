using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaElevator : MonoBehaviour
{
    public float movementSpeed;

    void Update()
    {
        transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
    }
}
