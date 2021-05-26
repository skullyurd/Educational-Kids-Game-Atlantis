using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class trigger_uitbarsting : MonoBehaviour
{
    [SerializeField] private VideoPlayer Vulkaan_animatie;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vulkaan_animatie.enabled = !Vulkaan_animatie.enabled;
            Destroy(this);
        }
    }
}
