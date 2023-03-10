using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    public string inputID;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode swtichKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward);
        //transform.Translate(Vector3.forward * Time.deltaTime * 20);

        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        // Moves the car based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(swtichKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
