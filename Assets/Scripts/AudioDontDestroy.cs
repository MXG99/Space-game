using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AudioDontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {       
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(1);
    }
}
