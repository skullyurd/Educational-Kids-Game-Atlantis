using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point_Cycle : MonoBehaviour
{
    [SerializeField] private Light sun;
    [SerializeField] private communicator_colour commun;

    [SerializeField] private Transform water;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            commun.R = commun.R - 0.00625f;
            commun.G = commun.G - 0.00625f;
            commun.B = commun.B - 0.00625f;

            sun.intensity = sun.intensity - 0.1f;

            water.localPosition += new Vector3(0, 0.0648f, 0);

            Destroy(this.gameObject);
        }
    }
}