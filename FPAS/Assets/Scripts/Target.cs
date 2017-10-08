using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    private float currentHealth = 100f;

    private void Start()
    {
        SetDefaults();
    }

    private void SetDefaults()
    {
        currentHealth = 100f;
    }

    public void TakeDamage(float amount, PlayerShoot _source)
    {
        currentHealth -= amount;

        if(currentHealth <= 0f)
        {
            DIE();
            _source.ConfirmKill(10);
        }
    }

    public void DIE()
    {
        Destroy(gameObject);
    }
}
