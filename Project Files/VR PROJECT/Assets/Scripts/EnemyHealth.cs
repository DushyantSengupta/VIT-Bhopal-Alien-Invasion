using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : revive
{
    public GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == obj)
        {
            Debug.Log("ho Rha hai");
            Destroy(obj);
            SceneManager.LoadScene("Died");
            count = 0;
        }
    }
}
   
