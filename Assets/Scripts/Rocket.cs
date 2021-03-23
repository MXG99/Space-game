using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rocket : MonoBehaviour {

    static public int savedScore;
    public int scor = 1;
    [SerializeField] float rcsThrust = 10f;
    [SerializeField] float mainThrust = 10f;
    [SerializeField] AudioClip mainEngine;
    
    [SerializeField] ParticleSystem engineParticles;
    [SerializeField] ParticleSystem successParticles;
    [SerializeField] ParticleSystem explosionParticles;
    [SerializeField] AudioClip Death;
    [SerializeField] AudioClip Success;

    [SerializeField] float DeathTimer = 3f;
    [SerializeField] float TranscendingTimer = 1f;
    Rigidbody rigidBody;
    AudioSource audioSource;

    bool ThrustParticlesOn;
    enum State { Alive, Dying, Transcending }
    State state = State.Alive;
    // Start is called before the first frame update
    void Start () {
        scor = savedScore;
        if(SceneManager.GetActiveScene().buildIndex == 4 || SceneManager.GetActiveScene().buildIndex == 5)
        {
            savedScore = 0;
        }
        rigidBody = GetComponent<Rigidbody> (); //Generics
        audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update () {
        if (state == State.Alive) {
            RespondToThrust ();
            Rotate ();
        }
        if(Input.GetKey(KeyCode.E))
        {
            engineParticles.Play();
        }
        if(Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if(state != State.Alive)
        {
            return;
        }
        if(collider.gameObject.tag == "Lava")
        {
            StartDeathSeq();
        }
    }
    void OnCollisionEnter (Collision collision) {

        if (state != State.Alive) {
            return;
        }
        switch (collision.gameObject.tag) {
            case "Friendly":
                break;
            case "Finish":
                StartSuccessSeq(TranscendingTimer);
                break;
            default:
                StartDeathSeq();
                break;
        }
    }

    private void StartDeathSeq()
    {
        state = State.Dying;
        explosionParticles.Play();
        audioSource.Stop();
        audioSource.PlayOneShot(Death, 0.01f);
        Invoke("GameOver", DeathTimer);
    }

    private void StartSuccessSeq(float TranscendingTimer)
    {
        state = State.Transcending;
        audioSource.Stop();
        audioSource.PlayOneShot(Success);
        successParticles.Play();
        Invoke("LoadNextScene", TranscendingTimer); //Cauta functia LoadNextScene dupa secundele precizate.
    }

    private void GameOver () {
        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            scor = savedScore;
            SceneManager.LoadScene(3);
        }
        else 
        {
            savedScore = scor;
            SceneManager.LoadScene(4);
        }
    }

    private void LoadNextScene () {
        savedScore = scor;
        if(SceneManager.GetActiveScene().buildIndex == 3)
            SceneManager.LoadScene(5);
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void RespondToThrust () {

        float thrustPower = mainThrust * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            engineParticles.Play();
        }
        if (Input.GetKey(KeyCode.Space)) {
            ThrustParticlesOn = true;
            ApplyThrust (thrustPower);
        } else {
            audioSource.Stop ();
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            engineParticles.Stop();
        }
    }

    private void ApplyThrust (float thrustPower) {
        rigidBody.AddRelativeForce (Vector3.up * thrustPower);
        if (!audioSource.isPlaying) {
            audioSource.PlayOneShot (mainEngine, 0.1f);
        }
    }

    private void Rotate () {

        rigidBody.freezeRotation = true; // take manual control of rotation

        float rotationSpeed = rcsThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.A)) {

            transform.Rotate (Vector3.forward * rotationSpeed);

        } else if (Input.GetKey(KeyCode.D)) {

            transform.Rotate (-Vector3.forward * rotationSpeed);
        }

        rigidBody.freezeRotation = false; // resume physics control of rotation
    }

}