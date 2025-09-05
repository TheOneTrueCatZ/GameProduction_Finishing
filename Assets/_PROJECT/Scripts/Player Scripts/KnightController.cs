using UnityEngine;
using UnityEngine.InputSystem;

public class KnightController : MonoBehaviour
{
    [SerializeField] private float knightHealth = 150f;
    [SerializeField] private float knightDamage = 25f;
    [SerializeField] private float knightSpeed = 5f;
    
    
    
    private float knightMaxHealth = 150f;

    void Start()
    {
        knightMaxHealth = knightHealth;
    }

    void Attack (InputAction.CallbackContext context)
    {
        //melee attack logic
        //Hellbert , pole arm thrust weapon
    }

    void Block(InputAction.CallbackContext context)
    {
        //block logic
        //block all frontal attacks
    }

    void Taunt(InputAction.CallbackContext context)
    {
        //Knight Ability1 Logic (Taunt)
        //Ups target priority from all enemies / gains 50 resistance
        // 15 - 25 seconds cooldown
    }

    void ShieldBash(InputAction.CallbackContext context)
    {
        //Knight Ability2 Logic (Shieldbash)
        //Knocks all enemies back and temporarily stuns / knockdown
        // 5 second cooldown
    }
    
}
