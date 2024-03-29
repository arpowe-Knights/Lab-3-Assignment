using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discounts : MonoBehaviour
{
    // displays variables in inspector
    public int bookPrice = 0;
    public int bookCopies = 0;
    private const double Discount = 0.40;

    private double shippingCost = 3;
    
    private double Wholesale = 0;
    private double profit = 0;
    void Start()
    {
        CalculateTotal();
    }

    // calculates total for profit and wholesale and checks for "1st" book "additional" book cost 
    public void CalculateTotal()
    {
        if (bookCopies > 1)
        {
            shippingCost = 0.75;
        }

        Wholesale = (bookPrice*bookCopies)+(bookCopies*shippingCost);
        profit = Wholesale - ((bookPrice*(1-Discount))*bookCopies)+(bookCopies*shippingCost);

        Debug.Log($"Total is: {Wholesale} and profit is: {profit}");
    }
}
