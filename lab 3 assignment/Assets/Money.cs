using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Money : MonoBehaviour
{
    // public int Payment = 0;

    public static void CalculateBills(int amount)
    {
      Dictionary<int,int> Dollarbills = new Dictionary<int, int>  
      {
        { 100, 0 }, // $100 bills
        { 50, 0 },  // $50 bills
        { 20, 0 },  // $20 bills
        { 10, 0 },  // $10 bills
        { 5, 0 },   // $5 bills
        { 1, 0 }    // $1 bills
      };
      foreach (var KeyValuePair in Dollarbills)
      {
        int bill = KeyValuePair.Key;
        int quantity = amount / bill;
        amount %= bill;

        Dollarbills[bill]=quantity;


      }

      foreach (var KeyValuePair in Dollarbills)
      {
        if(KeyValuePair.Value > 0)
        {
            Debug.Log($"Number of {KeyValuePair.Key} bills: {KeyValuePair.Value} Used");
        }
      }

    }
    
    


    public void Start()
    {
        int paymentAmount = 47;
        //Debug.Log($"Payment amount: ${paymentAmount}");
        CalculateBills(paymentAmount);
    }
      
}
