using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15f;
    private float horizontalInput;
    private float turnSpeed = 100f;
    private float verticalInput;
    private float acceleration;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            acceleration = 1.5f;
        }
        else
        {
            acceleration = 1;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput * acceleration);

        verticalInput = Input.GetAxis("Vertical");
        if(verticalInput != 0) transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
