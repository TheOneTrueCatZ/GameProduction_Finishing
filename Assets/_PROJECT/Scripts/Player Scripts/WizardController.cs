using System;
using UnityEngine;

public class WizardController : MonoBehaviour
{
    [SerializeField] private float wizardHealth = 75f;
    [SerializeField] private float wizardDamage = 35f;
    [SerializeField] private float wizardSpeed = 5f;
    
    private float wizardMaxHealth = 75f;

    private void Start()
    {
        wizardHealth = wizardMaxHealth;
    }
}
