using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song_check : MonoBehaviour
{
    private GameObject moet_weg;

    void Start()
    {
        moet_weg = GameObject.Find("Music_MainMenu(Clone)");

        if (moet_weg == null)
        {
            return;
        }
        else
        {
            Destroy(moet_weg);
        }
    }
}
