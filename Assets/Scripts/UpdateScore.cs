using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateScore : MonoBehaviour
{
    GameObject game;
    public TextMeshProUGUI textMesh;
    void Start()
    {
        game = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        int scor = game.GetComponent<Rocket>().scor;
        textMesh.text = "SCOR: " + scor;
    }
}
