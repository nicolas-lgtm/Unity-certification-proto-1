using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Vector3 offset = new Vector3(0, 5, -7);
    
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
