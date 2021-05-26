using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_changer : MonoBehaviour
{

    [SerializeField] private communicator_colour commun;

    [SerializeField] private SpriteRenderer shade;
    [SerializeField] private float R;
    [SerializeField] private float G;
    [SerializeField] private float B;

    void Update()
    {
        R = commun.R;
        G = commun.G;
        B = commun.B;
        //A = total; // transparity
        shade.color = new Color(R, G, B, 1); // 0,37 is fine
    }
}
