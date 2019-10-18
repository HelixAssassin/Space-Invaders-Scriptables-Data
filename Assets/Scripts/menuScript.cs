using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour { 

    public void loadMain ()
{
        SceneManager.LoadScene(1);
}

    public void exitGame ()
    {
        Application.Quit ();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}