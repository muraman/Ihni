using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
private Transform target;

public Vector3 offset;

public float smoothTime = 0.3f;

private Vector3 velocity;

private void Update() 
{
    target = GameObject.FindGameObjectWithTag("Player").transform;
}

private void FixedUpdate()
{
    transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref velocity, smoothTime);
}
}