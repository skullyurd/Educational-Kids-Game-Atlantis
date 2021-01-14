using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthquake : MonoBehaviour
{
    public Transform camTransform;

    public float shakeDuration = 0f;

    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;

    Follow_Player camera_follow;



    Vector3 originalPos;

    void Awake()
    {

        camera_follow = GameObject.Find("MainCamera").GetComponent<Follow_Player>();



        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }

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