using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject Menu;

    // Start is called before the first frame update
    void Start()
    {
        Pause();
    }

    void Pause()
    {
        Time.timeScale = 0;
        Menu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        Menu.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("return"))
            Pause();
    }
}