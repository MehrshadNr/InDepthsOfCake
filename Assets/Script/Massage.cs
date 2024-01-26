using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Massage : MonoBehaviour
{
    public GameObject latter;
    public bool inCol;
    Collision2D col1;
    private void Update()
    {
        if(inCol)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("1");
                latter.SetActive(true);
                col1.gameObject.GetComponent<PlayerMovement>().canMove = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        inCol = true;
        col1 = col;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        inCol = false;
    }

    public void back()
    {
        latter.SetActive(false);
        col1.gameObject.GetComponent<PlayerMovement>().canMove = true;
    }
}
