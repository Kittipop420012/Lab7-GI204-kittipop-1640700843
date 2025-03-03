using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothspeed = 2f;
    [SerializeField] Vector3 offset = new Vector3(0, 2, -5);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + target.TransformDirection(offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothspeed * Time.deltaTime);
        transform.LookAt(target);
    }

    // Update is called once per frame
}
