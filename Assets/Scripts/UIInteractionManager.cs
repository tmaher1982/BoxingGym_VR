using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInteractionManager : MonoBehaviour
{
    [SerializeField] private GameObject PunchSpeedBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayButton()
    {
        Debug.Log("Button is working");
        PunchSpeedBall.SetActive(true);
    }
}
