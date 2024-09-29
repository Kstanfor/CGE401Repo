using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* (Kaiser Stanford)
* (prototype 3)
* (allows player to jump)
*/

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public ForceMode forceMode;
    public float gravtityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    public Animator playerAnimator;

    public ParticleSystem explosionParticle;

    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;

    private AudioSource playerAudio;
    // Start is called before the first frame update
    void Start()
    {

        playerAudio = GetComponent<AudioSource>();

        playerAnimator = GetComponent<Animator>();

        playerAnimator.SetFloat("Speed_f", 1.0f);

        //rigid reference
        rb = GetComponent<Rigidbody>();

        forceMode = ForceMode.Impulse;

        if (Physics.gravity.y > -10) 
        {
            Physics.gravity *= gravtityModifier;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {

            rb.AddForce(Vector3.up * jumpForce, forceMode);
            isOnGround = false;

            playerAnimator.SetTrigger("Jump_trig");
            dirtParticle.Stop();

            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            isOnGround = true;
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;

            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);

            explosionParticle.Play();

            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
