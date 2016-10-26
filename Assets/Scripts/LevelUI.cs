using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class LevelUI : MonoBehaviour {
    //Timer
    public Text Timer;
    public float TimerValue= 0f;

	//Use this for initialization.
	void Start ()
    {
	
	}

    //Called once per frame.
    void Update()
    {
               
    }

    //Called according to timescale.
    void FixedUpdate()
    {
        TimerFunction();
    }

    //Sets the Timer.
    void TimerFunction()
    {
        TimerValue += Time.deltaTime;
        Timer.text = TimerValue.ToString("f2");
    }
    
}
