using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClericController : MonoBehaviour
{
    [SerializeField] private float clericHealth = 100f;
    [SerializeField] private float clericDamage = 35f;
    [SerializeField] private float clericSpeed = 5f;

    private float clericMaxHealth = 100f;

    private void Start()
    {
        clericHealth = clericMaxHealth;
    }

    void Attack(InputAction.CallbackContext context)
    {
        //basic attack for cleric 
        //mace weapon
    }

    void WeakBlock(InputAction.CallbackContext context)
    {
        //shoves back enemies slightly and player takes less damage for 1 second
        // 5 second cooldown
    }

    void MassHeal(InputAction.CallbackContext context)
    {
        //creates a healing circle around the cleric that takes 3 seconds to cast.
        //Heals all targets inside of ring, cannot heal past 75% of max health
        //can be interupted
    }

    void Thorns(InputAction.CallbackContext context)
    {
        //Creates a field of thorns that slows enemies inside of it 
        // last for 5 seconds 
        // 25 second cooldown
    }
}
