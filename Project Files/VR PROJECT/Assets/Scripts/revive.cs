using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class revive : MonoBehaviour {

  public Animator anim;
    protected static int count=0;
    public GameObject person;
    void Start()
    { 
        anim = GetComponent<Animator>();
    }

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
        if(count>=5)
        {
            SceneManager.LoadScene("Win");
            count = 0;
        }
    }
}
