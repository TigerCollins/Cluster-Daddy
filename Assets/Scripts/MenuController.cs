using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuController : MonoBehaviour {

    void Start()
    {

    }

    //Called once per frame.
    void Update()
    {

    }

    //Called according to timescale.
    void FixedUpdate()
    {

    }

    //Tests if the button works.
    public void TestClick()
    {
        Debug.Log("Button Pressed.");
    }

    //Loads Main Menu.
    public void MainMenu()
    {
        Application.LoadLevel("Main Menu");
    }

    //Quits to Desktop.
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application Quit. Only works in packaged version.");
    }

    //Opens Credits.
    public void Credits()
    {
        Application.LoadLevel("Credits");
    }

    //Opens Level 1.
    public void L1()
    {
        Application.LoadLevel("Level1");
    }

    //Opens Level 2.
    public void L2()
    {
        Application.LoadLevel("Level2");
    }

    //Opens Level 3.
    public void L3()
    {
        Debug.Log("Level 3.");
    }
}
