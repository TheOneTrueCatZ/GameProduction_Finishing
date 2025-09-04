using UnityEngine;

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
}
