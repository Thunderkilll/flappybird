using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        if (Input.anyKey)
        {
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }
    }
}
