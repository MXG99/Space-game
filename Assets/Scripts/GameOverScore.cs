using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    int points2;
    GameObject gm;
    public TextMeshProUGUI textMesh;
    
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("Player");
        points2 = gm.GetComponent<Rocket>().scor;
        textMesh.text = "SCOR: " + points2;
    }
}
