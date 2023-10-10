using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private void LateUpdate()
    {
        GameObject player = GameObject.Find("Player");
        Vector3 targetPosition = player.transform.position + new Vector3(-4, 2, 0);
        transform.position = targetPosition;
    }
}
