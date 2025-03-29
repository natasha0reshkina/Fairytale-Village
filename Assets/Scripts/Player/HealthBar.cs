using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    Image healthBar;
    public static float MaxHealth = 100f;  
    public static float HP;  
    public float decreaseRate = 0.4f;  

    public string nextSceneName = "NextScene";  
    public string nextSceneWinName = "NextScene";  
    void Start()
    {
        healthBar = GetComponent<Image>();
        HP = MaxHealth; 
    }

    void Update()
    {
        
        HP -= decreaseRate * Time.deltaTime;


        if (HP <= 0)
        {
            HP = 0;
       
            LoadNextScene();
        }
        else if (House.unfixed == 0)
        {
            LoadNextWinScene();
        }


        healthBar.fillAmount = HP / MaxHealth;
    }


    void LoadNextScene()
    {
        House.unfixed = 5;
        Money.money = 0;
 
        if (SceneManager.GetSceneByName(nextSceneName).isLoaded == false)
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.LogError("Сцена с именем " + nextSceneName + " не найдена или уже загружена!");
        }
    }
    void LoadNextWinScene()
    {
        Money.money = 0;
        House.unfixed = 5;
        if (SceneManager.GetSceneByName(nextSceneWinName).isLoaded == false)
        {
            SceneManager.LoadScene(nextSceneWinName);  
        }
        else
        {
            Debug.LogError("Сцена с именем " + nextSceneWinName + " не найдена или уже загружена!");
        }
    }
}