using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {
    //Menus
    public GameObject pauseMenu;
    public GameObject winMenu;

    //Death
    public int deathCount = 0;
    public Text deathCountText;
    public Text deathCountWinText;

    //Timer
    public Text Timer;
    public Text PauseTimer;
    public Text WinTimer;
    public float TimerValue = 0f;

    //Win
    public GameObject audioWin;

    //When the object collides with another object.
    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Death") //If a conveyer belt has this tag it will...
        {
            Death(); //... Start this class.
        }

        if (col.gameObject.tag == "Win") //If a conveyer belt has this tag it will...
        {
            Win(); //... Start this class.
        }
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bonus") //If a conveyer belt has this tag it will...
        {
            TimerBonus(); //... Start this class.
        }
    }


    // Use this for initialization
    void Start ()
    {
        Time.timeScale = 1f;
        Cursor.visible = false; //Disables the visible mouse when the scene opens.
        Screen.lockCursor = true;
    }
	

	// Update is called once per frame
	void Update ()
    {
        Pause();
        TimerFunction();
    }


    void Death() //Handles what happens upon death.
    {
        deathCount += 1; //Adds 1 to the death counter.
        transform.position = new Vector3(1957,-33, 1538);
        deathCountText.text = deathCount.ToString() + " Deaths";
        deathCountWinText.text = deathCount.ToString() + " Deaths";
    }

    
    void Pause()
    {
        //When escape is pressed, the game pauses.
        if (Input.GetKey("escape"))
        {
            Time.timeScale = 0f;
            Cursor.visible = true;
            Screen.lockCursor = false;
            pauseMenu.SetActive(true);
        }
    }


    void Win()
    {
        //When the player reaches the win flag...
            Time.timeScale = 0f;
            Cursor.visible = true;
        winMenu.SetActive(true);
        Screen.lockCursor = false;
        audioWin.SetActive(true);
    }


    //Sets the Timer.
    void TimerFunction()
    {
        TimerValue += Time.deltaTime;
        Timer.text = TimerValue.ToString("f2");
        PauseTimer.text = TimerValue.ToString("f2") + " Seconds";
        WinTimer.text = TimerValue.ToString("f2") + " Seconds";
    }


    public void TimerBonus()
    {
       TimerValue -= 5; //Takes 5 seconds off the timer.
    }
}
