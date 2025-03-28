using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Image healthBar;
    public static float MaxHealth = 100f;  // Максимальное здоровье
    public static float HP;  // Текущее здоровье
    public float decreaseRate = 0.1f;  // Очень медленное уменьшение здоровья в секунду

    void Start()
    {
        healthBar = GetComponent<Image>();
        HP = MaxHealth;  // Устанавливаем начальное значение здоровья равным MaxHealth
        Debug.Log("Начальное здоровье: " + HP);  // Проверка начального значения здоровья
    }

    void Update()
    {
        // Уменьшаем здоровье с учетом времени (очень медленно)
        HP -= decreaseRate * Time.deltaTime;

        // Ограничиваем здоровье, чтобы оно не стало меньше 0
        if (HP < 0)
        {
            HP = 0;
        }

        // Обновляем визуальное отображение здоровья
        healthBar.fillAmount = HP / MaxHealth;

        // Проверка значений HP для отладки
        Debug.Log("Текущее здоровье: " + HP);
    }
}