using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Bill
{
    public int dollarBill;
    public int quantity;
}

public class change : MonoBehaviour
{
    // shows private variable in inspector
     [SerializeField]
    private int paymentAmount = 47;
    // List of all possible dollar bills 
    private List<Bill> dollarBills = new()
    {
        new Bill { dollarBill = 100, quantity = 0 },
        new Bill { dollarBill = 50, quantity = 0 },
        new Bill { dollarBill = 20, quantity = 0 },
        new Bill { dollarBill = 10, quantity = 0 },
        new Bill { dollarBill = 5, quantity = 0 },
        new Bill { dollarBill = 1, quantity = 0 }
    };

    //  iterates through a list of bills and calculates the quantity of each bill needed to make a payment
    public void CalculateBills(int paymentAmount)
    {
        foreach (var bill in dollarBills)
        {
            int quantity = paymentAmount / bill.dollarBill;
            paymentAmount %= bill.dollarBill;

            bill.quantity = quantity;
        }
    }

    void Start()
    {
        CalculateBills(paymentAmount);

        // Log the bills in the console
        foreach (var bill in dollarBills)
        {
            Debug.Log($"Number of ${bill.dollarBill} bills: {bill.quantity}");
        }
    }
}
