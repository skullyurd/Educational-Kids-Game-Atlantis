using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthquake : MonoBehaviour
{
    [SerializeField] private Transform camTransform;

    [SerializeField] private float shakeDuration = 0f;

    [SerializeField] private float shakeAmount = 0.7f;
    [SerializeField] private float decreaseFactor = 1.0f;

    [SerializeField] private Follow_Player camera_follow;

    private Vector3 originalPos;

    void OnEnable()
    {
        originalPos = camTransform.localPosition;
    }

    void Update()
    {
        if (shakeDuration > 0)
        {
            camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

            shakeDuration -= Time.deltaTime * decreaseFactor;

        }
        else
        {
            shakeDuration = 0f;
            camTransform.localPosition = originalPos;
        }

        if(shakeDuration == 0)
        {
            camera_follow.enabled = !camera_follow.enabled;
            Destroy(this.gameObject);
        }
    }
}