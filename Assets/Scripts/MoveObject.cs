using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    [SerializeField]
    int moveCounter = 0;
    [SerializeField]
    private float moveForce = 1f,
        movementX = -0.005f,
        movementY = 0f,
        movementZ = -0.005f;
    public float moveSpeed = 5f; // speed of movement

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveCounter >= 5000) {
            audioSource.Stop();
            return;
        }

        transform.position -= new Vector3(movementX, movementY, movementZ) * Time.deltaTime * moveForce;
        //transform.position -= transform.forward * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        moveCounter++;


        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
