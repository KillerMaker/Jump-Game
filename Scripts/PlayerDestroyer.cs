using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem explosion;
    private PlayerControllerX playerController;

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            explosion.Play();
            playerController.gameOver = true;
            Invoke(nameof(playerController.restartScene), 2f);
        }

    }

}
