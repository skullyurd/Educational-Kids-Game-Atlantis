using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song_check : MonoBehaviour
{

    public GameObject moet_weg;

    // Start is called before the first frame update
    void Start()
    {
        moet_weg = GameObject.Find("Music_MainMenu(Clone)");

        if (moet_weg == null)
        {
            //nothing
        }
        else
        {
            Destroy(moet_weg);
        }
    }
}
