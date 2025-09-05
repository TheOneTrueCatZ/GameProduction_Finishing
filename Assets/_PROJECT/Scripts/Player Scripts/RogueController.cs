using UnityEngine;
using UnityEngine.InputSystem;

public class RogueController : MonoBehaviour
{
    [SerializeField] private float rogueHealth = 100f;
    [SerializeField] private float rogueDamage = 35f;
    [SerializeField] private float rogueSpeed = 7f;
    
    private float rogueMaxHealth = 100f;

    void start()
    {
        rogueHealth = rogueMaxHealth;
    }

    void Attack(InputAction.CallbackContext context)
    {
        //fast but weak dagger attacks
        //double damage vs ranged enemies 
    }

    void Dash(InputAction.CallbackContext context)
    {
        //freezes player in places and makes them dash in the direction that they are looking.
        //5 second cooldown
    }

    void Stealth(InputAction.CallbackContext context)
    {
        //Rogue ability 1, clocks the rogue and sets their target priority to 0 for 5 seconds or untill the player attacks or uses another ability.
    }

    void poison(InputAction.CallbackContext context)
    {
        //makes all attacks do poison damage for 4 seconds
        //poison slows down effected enemies and makes they take additional damage for 10 seconds 
    }
}
