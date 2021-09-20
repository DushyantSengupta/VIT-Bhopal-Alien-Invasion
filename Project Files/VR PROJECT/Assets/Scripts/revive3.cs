using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class revive3 : revive {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == person)
        {
            anim.SetInteger("condition", 1);
            count++;
            Debug.Log("happen");
        }
    }
    void Update()
    {
        if (count >= 5)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
