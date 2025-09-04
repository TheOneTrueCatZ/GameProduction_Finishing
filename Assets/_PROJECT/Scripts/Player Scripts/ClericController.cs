using System;
using UnityEngine;

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
}
