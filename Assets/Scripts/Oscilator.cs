using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscilator : MonoBehaviour {

    [SerializeField] float period = 2f;
    [SerializeField] Vector3 movementVector = new Vector3 (10f, 10f, 10f);
    [Range (0, 1)][SerializeField] float movementFactor;

    Vector3 startingPosition;

    // Start is called before the first frame update
    void Start () {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update () {
        if (period <= Mathf.Epsilon) { return; }

        float cycles = Time.time / period;

        const float tau = Mathf.PI * 2; // aproximativ 6.28
        float rawSinWave = Mathf.Sin (cycles * tau); // -1 to +1 

        movementFactor = rawSinWave / 2f + 0.5f;
        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}