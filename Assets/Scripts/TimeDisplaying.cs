using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimeDisplaying : MonoBehaviour
{
    private TextMeshProUGUI timeTxt;
    private float time = 0;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Vehicule").GetComponent<PlayerController>();
        timeTxt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.raceIsActive)
        {
            time += Time.deltaTime;
            timeTxt.text = time.ToString("0.00");
        }
    }
}
