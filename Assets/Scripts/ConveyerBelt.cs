using UnityEngine;
using System.Collections;

public class ConveyerBelt : MonoBehaviour {

    public float thrust = 500;
    public float hillThrust = 500;
    public Rigidbody rb;

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Belt0") //If a conveyer belt has this tag it will...
        {
            Forwards();//... Start this class.
        }

        if (col.gameObject.tag == "Belt90") //If a conveyer belt has this tag it will...
        {
           Right();//... Start this class.
        }

        if (col.gameObject.tag == "Belt-90") //If a conveyer belt has this tag it will...
        {
            Left();//... Start this class.
        }

        if (col.gameObject.tag == "Belt180") //If a conveyer belt has this tag it will...
        {
            Backwards();//... Start this class.
        }

        if (col.gameObject.tag == "HillBelt90") //If a conveyer belt has this tag it will...
        {
            HillRight();//... Start this class.
        }

        if (col.gameObject.tag == "HillBelt-90") //If a conveyer belt has this tag it will...
        {
            HillLeft();//... Start this class.
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Grabs the RB on the object it is attached to.
    }

    void Forwards()
    {
        rb.AddForce(new Vector3(0,0,-1) * thrust) ;//Adding force Forward.
    }

    void Backwards()
    {
        rb.AddForce(new Vector3(0, 0, 1) * thrust);//Adding force Forward.
    }

    void Left()
    {
        rb.AddForce(new Vector3(1, 0,0) * thrust);//Adding force Forward.
    }
    void Right()
    {
        rb.AddForce(new Vector3(-1, 0, 0) * thrust);//Adding force Forward.
    }

    void HillLeft()
    {
        rb.AddForce(new Vector3(1, 0, 0) * hillThrust);//Adding force Forward.
    }
    void HillRight()
    {
        rb.AddForce(new Vector3(-1, 0, 0) * hillThrust);//Adding force Forward.
    }

}
