using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatRock : MonoBehaviour
{
    [SerializeField] private float rockSpeed = 1.0f;
    [SerializeField] private float rockDistance = 1.0f;
    [SerializeField] private float timeOffset = 0.0f;

    private Vector3 originalPosition;

    private void Awake()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        var offset = Mathf.Sin(Time.time * rockSpeed + timeOffset) * rockDistance;
        transform.position = originalPosition + new Vector3(0.0f, offset, 0.0f);
    }
}
