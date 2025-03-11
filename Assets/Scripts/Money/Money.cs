using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Money : MonoBehaviour
{
     public static int money;
     public  Text moneyText;
    void Start()
    {
        
    }

 
    void Update()
    {
        moneyText.text = "" + money;
    }
    
}
