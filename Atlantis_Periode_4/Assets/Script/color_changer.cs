using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_changer : MonoBehaviour
{

    communicator_colour commun;

    public SpriteRenderer shade;
    public float R;
    public float G;
    public float B;

    // Start is called before the first frame update
    void Start()
    {
        shade = this.gameObject.GetComponent<SpriteRenderer>();
        commun = GameObject.Find("communicator").GetComponent<communicator_colour>();
    }

    // Update is called once per frame
    void Update()
    {
        R = commun.R;
        G = commun.G;
        B = commun.B;
        //A = total; // transparity
        shade.color = new Color(R, G, B, 1); // 0,37 is goed
    }
}
