using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_Functions : MonoBehaviour
{

    Text text_inlevel;

    public int fact_number;

    public bool pause;
    public bool Dag;

    void Start()
    {
        text_inlevel = GameObject.Find("Text").GetComponent<Text>();
    }

    public void start_game()
    {
        SceneManager.LoadScene(1);
    }
    
    public void go_back()
    {
        SceneManager.LoadScene(0);
    }

    public void go_collection()
    {
        SceneManager.LoadScene(4);
    }

    public void pause_game()
    {
        pause = !pause;

        switch (pause)
        {
            case true:
                Time.timeScale = 0;
                text_inlevel.text = "Klik nog eens op de pauze knop om het spel te hervatten";
                break;

            case false:
                Time.timeScale = 1;
                text_inlevel.text = " ";
                break;
        }


    }
    public void quit_game()
    {
        Application.Quit();
    }
    public void Villager_level()
    {
        SceneManager.LoadScene(2);
    }
    public void call_fact()
    {
        fact_number = Random.Range(1, 11);


        switch (Dag)
        {
            case true:

                switch (fact_number)
                {
                    case 1:
                        text_inlevel.text = "Wat een leven, Atlantis is rijk, goed beschermd, werk zat. Mijn gezin zal het hier geweldig hebben";
                        StartCoroutine(clear_text());
                        break;

                    case 2:
                        text_inlevel.text = "In Atlantis kan wat moeilijk overkomen, de hoge muren en het water tussen de ringen beschermt ons van allerlei soorten gevaren!";
                        StartCoroutine(clear_text());
                        break;
                    case 3:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;

                    case 4:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;

                    case 5:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;

                    case 6:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;
                    case 7:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;

                    case 8:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;
                    case 9:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;

                    case 10:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;
                }

                break;

            case false:

                switch (fact_number)
                {
                    case 1:
                        text_inlevel.text = " hoe kan alles zo makkelijk kapot gaan? Atlantis is sterker gebouwt dan elk koninkrijk dan ook.";
                        StartCoroutine(clear_text());
                        break;
                    case 2:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;

                    case 3:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;
                    case 4:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;

                    case 5:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;
                    case 6:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;

                    case 7:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;
                    case 8:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;

                    case 9:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;
                    case 10:
                        text_inlevel.text = "";
                        StartCoroutine(clear_text());
                        break;
                }
                break;

        }

    }

    IEnumerator clear_text()
    {
        yield return new WaitForSeconds(4);
        text_inlevel.text = "";
    }
}
