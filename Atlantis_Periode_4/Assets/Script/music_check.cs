using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_check : MonoBehaviour
{
    [SerializeField] private GameObject music;
    [SerializeField] private GameObject addMusic;

    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.Find("Music_MainMenu(Clone)");

        if (music == null)
        {
            Instantiate(addMusic, new Vector3(0, 0, 0), Quaternion.identity);
            Debug.Log("er is niks");
        }
        if(music != null)
        {
            Debug.Log("er is iets");
        }
    }
}
