using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameObject nextCheckpoint;

    private void Start()
    {
        if (transform.parent.childCount > 1)
        {
            nextCheckpoint = GameObject.Find("Checkpoint " + (transform.GetSiblingIndex() + 2).ToString());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GetComponentInChildren<Light>().enabled)
        {
            if (nextCheckpoint)
            {
                nextCheckpoint.GetComponentInChildren<Light>().enabled = true;
                nextCheckpoint.GetComponent<Renderer>().material.color = Color.yellow;
            }

            Destroy(gameObject);
        }
    }
}
