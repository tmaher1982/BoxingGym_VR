using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnCollision : MonoBehaviour
{
    public AudioSource punchSound;

    // Start is called before the first frame update
    void Start()
    {
        punchSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            punchSound.Play();
        }
    }
}
