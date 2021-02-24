using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// - No redundancy
/// - Results (total) two decimal places
/// </summary>
namespace Assets.TipCalculator
{
    public class TipCalculator : MonoBehaviour
    {
        [SerializeField] private float _bill = 20f;
        [SerializeField] private float[] _tips = { 15f, 20f, 25f };
        [SerializeField] private float _tipCustom = 0f;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Your bill is $" + _bill);
                foreach (var tip in _tips)
                {
                    CalculateTip(tip, false);
                }
                CalculateTip(_tipCustom, true);
            }
        }

        void CalculateTip(float tip, bool isCustom)
        {
            float tipAmount = _bill * tip/100;
            float total = _bill + tipAmount;

            if (!isCustom)
            {
                Debug.Log(tip.ToString() + "% tip = $" + tipAmount + " with a final total of: $" + total.ToString("F2"));
            }
            else // custom tip
            {
                Debug.Log("Your custom tip of " + tip.ToString() + "% = $" + tipAmount + " with a final total of: $" + total.ToString("F2"));
            }

        }
    } 
}
