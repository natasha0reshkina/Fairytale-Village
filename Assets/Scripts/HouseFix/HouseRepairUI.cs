using UnityEngine;
using UnityEngine.UI;

public class HouseRepairUI : MonoBehaviour
{
    public static HouseRepairUI instance;

    [SerializeField] private GameObject repairButtonObject;
    private Button repairButton;
    private House currentHouse; // Дом, который необходимо починить

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        repairButton = repairButtonObject.GetComponent<Button>();
        repairButton.onClick.AddListener(OnRepairClicked);
        repairButtonObject.SetActive(false);
    }

    // Вызывается, чтобы показать кнопку и сохранить ссылку на дом
    public static void ShowRepairButton(House house)
    {
        if (instance == null || instance.repairButtonObject == null)
        {
            Debug.LogError("repairButtonObject не назначен или instance = null");
            return;
        }
        Debug.Log(house);
        Debug.Log(house.IsBroken());
        if (house != null && house.IsBroken())
        {
            
            instance.currentHouse = house;
            instance.repairButtonObject.SetActive(true);
        }
    }

    // При нажатии на кнопку дом чинится
    private void OnRepairClicked()
    {
        if (Money.money >= 100 && currentHouse != null && currentHouse.IsBroken())
        {
            currentHouse.Fix();
            repairButtonObject.SetActive(false);
        }
    }
}