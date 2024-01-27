using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Massage : MonoBehaviour
{
    public GameObject latter;
    public GameObject E;
    public AudioSource voice;
    public bool inCol;
    public bool inPlay;
    public float time;
    Collision2D col1;
    private void Update()
    {
        if(inCol)
        {
            if(!inPlay)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    voice.Play();
                    inPlay = true;
                    StartCoroutine(Wait());
                    E.SetActive(false);
                    //latter.SetActive(true);
                    //col1.gameObject.GetComponent<PlayerMovement>().canMove = false;
                }
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        inCol = true;
        col1 = col;
        if(!inPlay)
        {
            E.SetActive(true);
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        inCol = false;
        E.SetActive(false);
    }

    public void back()
    {
        latter.SetActive(false);
        col1.gameObject.GetComponent<PlayerMovement>().canMove = true;
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(time);
        inPlay = false;
        gameObject.GetComponent<ShowPortal>()._portal();
    }
}
