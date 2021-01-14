using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class trigger_uitbarsting : MonoBehaviour
{

    VideoPlayer Vulkaan_animatie;

    // Start is called before the first frame update
    void Start()
    {
        Vulkaan_animatie = GameObject.Find("volcano background").GetComponent<VideoPlayer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vulkaan_animatie.enabled = !Vulkaan_animatie.enabled;
            Destroy(this);
        }
    }

}
