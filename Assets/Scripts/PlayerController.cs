using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    [SerializeField] float turnSpeed = 100f;
    [SerializeField] GameObject checkpointParent;

    private float horizontalInput;
    private float verticalInput;

    private float acceleration;

    public bool raceIsActive;

    [SerializeField] Button restartButton;

    void FixedUpdate()
    {
        if (raceIsActive)
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
            if (verticalInput != 0) transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Arrival") && checkpointParent.transform.childCount <= 0)
        {
            raceIsActive = false;
            restartButton.gameObject.SetActive(true);
        }
    }
}
