using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    // Start is called before the first frame updatess
    void Start()
    {
       offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        Vector3 newPos = player.position + offset;
        // transform.position = Vector3.lerp(transform.position, newPos, SmoothFactor);
        transform.position = Vector3.Lerp(transform.position, newPos, 0.6f);
    }
}
