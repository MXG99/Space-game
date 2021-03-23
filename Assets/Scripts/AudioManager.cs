using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AudioManager : MonoBehaviour
{
    public AudioSource BGM;
    public Slider Volume;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Volume.value = 0.5f;
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        BGM.volume = Volume.value;
    }
}
