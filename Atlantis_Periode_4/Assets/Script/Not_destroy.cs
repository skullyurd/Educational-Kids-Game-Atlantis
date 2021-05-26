using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Not_destroy : MonoBehaviour
{
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
