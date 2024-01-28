using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Bill
{
    public int denomination;
    public int quantity;
}

public class change : MonoBehaviour
{
     [SerializeField]
    private int paymentAmount = 47;
    public List<Bill> dollarBills = new List<Bill>
    {
        new Bill { denomination = 100, quantity = 0 },
        new Bill { denomination = 50, quantity = 0 },
        new Bill { denomination = 20, quantity = 0 },
        new Bill { denomination = 10, quantity = 0 },
        new Bill { denomination = 5, quantity = 0 },
        new Bill { denomination = 1, quantity = 0 }
    };

    public void CalculateBills(int paymentAmount)
    {
        foreach (var bill in dollarBills)
        {
            int quantity = paymentAmount / bill.denomination;
            paymentAmount %= bill.denomination;

            bill.quantity = quantity;
        }
    }

    void Start()
    {
        CalculateBills(paymentAmount);

        // Log the bills in the console
        foreach (var bill in dollarBills)
        {
            Debug.Log($"Number of ${bill.denomination} bills: {bill.quantity}");
        }
    }
}
