using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    private float countdown = 3;
    [SerializeField] TextMeshProUGUI countdownTxt;
    private PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Vehicule").GetComponent<PlayerController>();
        playerControllerScript.raceIsActive = false;
      //  StartCoroutine(f_Countdown());
    }

    private void Update()
    {

        if (countdown <= -.9f)
        {
            playerControllerScript.raceIsActive = true;
            this.gameObject.SetActive(false);
            countdownTxt.gameObject.SetActive(false);
            GameObject.Find("Checkpoint 1").gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            countdown -= Time.deltaTime;
            countdownTxt.text = (Mathf.Ceil(countdown)).ToString();
        }

    }
}
