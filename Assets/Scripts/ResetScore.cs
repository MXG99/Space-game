using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    GameObject game;
    void Start()
    {
        game = GameObject.FindGameObjectWithTag("Player");
        game.GetComponent<Rocket>().scor = 0;
    }
}
