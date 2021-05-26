using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_villager : MonoBehaviour
{

    [SerializeField] private Text text_inlevel;
    [SerializeField] private int dialogue_numb;

    void Start()
    {
        text_inlevel = GameObject.Find("Text").GetComponent<Text>();
        if(dialogue_numb == 0)
        {
            text_inlevel.text = "Mijn werk is gedaan. Het is tijd om naar huis te gaan waar m'n gezin is.";
            StartCoroutine(clear_text());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (dialogue_numb)
            {
                case 1:
                    text_inlevel.text = "Een vulkaan uitbarsting? Gelukkig is het zo ver dat we er geen last van hebben"; // na vulkaan
                    StartCoroutine(clear_text());
                    break;

                case 2:
                    text_inlevel.text = "De aardbevingen zijn heftig... Ik moet snel kijken of het thuis goed gaat!"; // na eerste aardbeving en vallende gebouw
                    StartCoroutine(clear_text());
                    break;

                case 3:
                    text_inlevel.text = "Het stad loopt onder water! Ik moet nu iedereen thuis weghalen. We kunnen niet zwemmen!"; // onderweg naar huis
                    StartCoroutine(clear_text());
                    break;

                case 4:
                    text_inlevel.text = "Nog even… Nog even en dan ben ik bij hun"; // water halverwege torso
                    StartCoroutine(clear_text());
                    break;
            }

        }
    }

    IEnumerator clear_text()
    {
        yield return new WaitForSeconds(4);
        text_inlevel.text = "";
        Destroy(this);
    }
}
