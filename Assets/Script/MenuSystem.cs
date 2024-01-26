using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSystem : MonoBehaviour
{
    public GameObject MenuCanvas;
    public GameObject StartGameCanvas;
    public GameObject CreditCanvas;
    public GameObject OptionCanvas;
    public DataManger dataManger;
    public Image BoardPanel;
    public Sprite[] boardsprits;
    public int SpriteSelect;


    void Start()
    {
        MenuCanvas.SetActive(true);
        StartGameCanvas.SetActive(false);
        CreditCanvas.SetActive(false);
        OptionCanvas.SetActive(false);

    }
    private void Update()
    {
    }

    public void _MenuCanvas()
    {
        MenuCanvas.SetActive(true);
        StartGameCanvas.SetActive(false);
        CreditCanvas.SetActive(false);
        OptionCanvas.SetActive(false);
    }
    public void _StartGameCanvas()
    {
        MenuCanvas.SetActive(false);
        StartGameCanvas.SetActive(true);
        CreditCanvas.SetActive(false);
        OptionCanvas.SetActive(false);
    }
    public void _CreditCanvas()
    {
        MenuCanvas.SetActive(false);
        StartGameCanvas.SetActive(false);
        CreditCanvas.SetActive(true);
        OptionCanvas.SetActive(false);
    }
    public void _OptionCanvas()
    {
        MenuCanvas.SetActive(false);
        StartGameCanvas.SetActive(false);
        CreditCanvas.SetActive(false);
        OptionCanvas.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }



    public void next()
    {
        if (SpriteSelect < boardsprits.Length)
        {
            SpriteSelect += 1;
            BoardPanel.sprite = boardsprits[SpriteSelect-1];
        }
    }
    public void prev()
    {
        if(SpriteSelect-1 > 0)
        {
            SpriteSelect -= 1;
            BoardPanel.sprite = boardsprits[SpriteSelect-1];
        }
    }



    public void Music(int val)
    {
        if(val == 0)
        {

        }
        if (val == 1)
        {

        }
    }


    public void Mode(int val)
    {
        if (val == 0)
        {

        }
        if (val == 1)
        {

        }
    }

    // start game
    public void start()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
