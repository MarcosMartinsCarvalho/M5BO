using UnityEngine;
using TMPro;

public class CashManager : MonoBehaviour
{
    public TextMeshProUGUI cashText;
    [SerializeField] private int currentCash = 1000; 

    void Start()
    {
        UpdateCashDisplay();
    }
  
    public bool DeductCash(int amount)
    {
        if (currentCash >= amount)
        {
            currentCash -= amount;
            UpdateCashDisplay();
            return true;
        }
        return false;
    }   
    public void AddCash(int amount)
    {
        currentCash += amount;
        UpdateCashDisplay();
    }

    private void UpdateCashDisplay()
    {
        cashText.text = "Cash: $" + currentCash.ToString();
    }
}
