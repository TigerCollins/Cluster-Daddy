using UnityEngine;
using System.Collections;

public class UniversalScriptController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static UniversalScriptController Instance;
    void Awake()
    {

        if (Instance)
            DestroyImmediate(gameObject);
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;

        }
    }
}
