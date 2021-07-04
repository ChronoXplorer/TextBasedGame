using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    [SerializeField] Text textComponent;
    
    void Start()
    {
        textComponent.text = ("Testing a text for a test");
    }
    
    void Update()
    {
        
    }
}
