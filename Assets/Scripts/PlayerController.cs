using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    //[SerializeField] private float speed = 15f;
    //[SerializeField] private float horsePower = 20000f;
    [SerializeField] const float turnSpeed = 100;
    [SerializeField] const float forwardSpeed = 25;
    [SerializeField] GameObject checkpointParent;
    //[SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedTxt;
    [SerializeField] TextMeshProUGUI RPMTxt;
    //[SerializeField] private List<WheelCollider> listOfWheels;

    private float speed;//speed displayed
    private float rpm;

    private float horizontalInput;
    private float verticalInput;

    private float acceleration;

    public bool raceIsActive;

    [SerializeField] Button restartButton;

    //private Rigidbody playerRb;

    private void Start()
    {
        //playerRb = GetComponent<Rigidbody>();
        // playerRb.centerOfMass = centerOfMass.transform.position;
    }

    void FixedUpdate()
    {
        if (raceIsActive)
        {
            //if (IsOnGround())
            //{
            if (Input.GetKey(KeyCode.LeftShift))
            {
                acceleration = 2f;
            }
            else
            {
                acceleration = 1f;
            }

            horizontalInput = Input.GetAxis("Horizontal");

            //playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput * acceleration);

            verticalInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed * verticalInput * acceleration);



            if (verticalInput != 0) transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
            //}

            //speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 3.6f);
            rpm = speed % 30 * 40;

            //speedTxt.SetText(speed.ToString() + " km/h");
            RPMTxt.SetText(rpm.ToString() + "RPM");
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

    //bool IsOnGround()
    //{
    //    int wheelsGrounded = 0;

    //    foreach (WheelCollider wheel in listOfWheels)
    //    {
    //        if (wheel.isGrounded)
    //        {
    //            wheelsGrounded++;
    //        }
    //    }

    //    return wheelsGrounded == 4;

    //}
}
