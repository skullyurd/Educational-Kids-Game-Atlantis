using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_earthquake : MonoBehaviour
{
    [SerializeField] private Follow_Player camera_follow;
    [SerializeField] private Earthquake aardbeving_script;
    [SerializeField] private AudioSource aardbeving_geluid;
    [SerializeField] private AudioSource music_happy;
    [SerializeField] private Button_Functions switch_ramp;

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
