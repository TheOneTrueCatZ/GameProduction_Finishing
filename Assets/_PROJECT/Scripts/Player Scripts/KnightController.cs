using UnityEngine;

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
    
    
}
