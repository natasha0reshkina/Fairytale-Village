using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
     public static int money;
     public  TextMeshProUGUI moneyText;
    void Start()
    {
        
    }

 
    void Update()
    {
        moneyText.text = "" + money;
    }
    
}
