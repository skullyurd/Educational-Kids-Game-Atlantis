using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_earthquake : MonoBehaviour
{
    Follow_Player camera_follow;
    Earthquake aardbeving_script;
    AudioSource aardbeving_geluid;
    AudioSource music_happy;
    Button_Functions switch_ramp;

    void Start()
    {
        aardbeving_script = GameObject.Find("Earthquake").GetComponent<Earthquake>();
        camera_follow = GameObject.Find("MainCamera").GetComponent<Follow_Player>();
        aardbeving_geluid = GameObject.Find("Earthquake").GetComponent<AudioSource>();
        music_happy = GameObject.Find("Music_Bewoner").GetComponent<AudioSource>();
        switch_ramp = GameObject.Find("MainCamera").GetComponent<Button_Functions>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera_follow.enabled = !camera_follow.enabled;
        aardbeving_script.enabled = !aardbeving_script.enabled;
        aardbeving_geluid.enabled = !aardbeving_geluid.enabled;
        music_happy.enabled = !music_happy.enabled;
        switch_ramp.Dag = false;
        Destroy(this);
    }
}
