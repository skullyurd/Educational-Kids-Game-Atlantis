using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Cutscene_over : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Go_Back());
    }

    IEnumerator Go_Back()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(0);
    }

}
