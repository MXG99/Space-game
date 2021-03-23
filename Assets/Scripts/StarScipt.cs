using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScipt : MonoBehaviour
{
    GameObject GM;
    public void OnTriggerEnter(Collider other)
    {
        GM = GameObject.FindGameObjectWithTag("Player");
        if(other.CompareTag("Player"))
        {
            GM.GetComponent<Rocket>().scor++;
            Destroy(this.gameObject);
        }

    }
}
