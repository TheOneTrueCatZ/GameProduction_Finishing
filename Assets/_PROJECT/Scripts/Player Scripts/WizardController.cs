using System;
using UnityEngine;
using UnityEngine.InputSystem;

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

    void Attack(InputAction.CallbackContext context)
    {
        // basic attack for wizard (wip)
        // spawns weak projectiles that seek out targest
    }

    void Shove(InputAction.CallbackContext context)
    {
        //shoves back enemies 
        // 2-3 second cooldown
    }

    void FireBall(InputAction.CallbackContext context)
    {
        //player is stuck in place to cast a fireball that deals massive damage 
        //cannot be interupted but player is valnerable to damage
        // 30 - 35 seconds cooldown
    }

    void ScortchehEarth(InputAction.CallbackContext context)
    {
        //Player covers a small area in fire, enemies inside of it takes continous damage
        //10 second cooldown
    }
}
