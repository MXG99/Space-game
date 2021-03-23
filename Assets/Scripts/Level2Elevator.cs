using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Elevator : MonoBehaviour
{
    public float movementSpeed;
    private float timp;
    void Start()
    {
        timp = Time.time;
    }
    void Update()
    {
        float LavaStart = Time.time - timp;
        if(LavaStart > 10)
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
    }
}
