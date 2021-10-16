using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int health;

    private int attack;
    private int critRate;
    private int critDamage;
    private int accuracy;

    public PlayerMovePromptController playerController;
    public Controller_Game gameController;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        health = 10_000;
        critRate = 35;
        critDamage = 2;

        attack = 1000;
        accuracy = 75;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyAttack()
    {
        int damage = getAttack();
        bool isCrit = false;

        int crit = Random.Range(1, 100);
        int hit = Random.Range(1, 100);

        if (crit >= getCritRate())
        {
            damage *= getCritDamage();
        }

        if (hit >= getAccuracy())
        {
            player.DamagePlayer(damage);
            //TODO: Add hitting animation;
            //Use bool "isCrit" to trigger an extra "Critical hit!" text animation.
            Debug.Log("Player was damaged " + damage + " HP!");
        }

        gameController.ToggleMovePrompt();
    }

    // Damage Methods
    public void DamageEnemy(int damage)
    {
        removeHealth(damage);
    }

    // Getters and Setters for Health

    public int getHealth()
    {
        return health;
    }

    public void setHealth(int amount)
    {
        health = amount;
    }

    public void addHealth(int amount)
    {
        setHealth(getHealth() - amount);
    }

    public void removeHealth(int amount)
    {
        setHealth(getHealth() - amount);
    }

    public int getCritRate()
    {
        return critRate;
    }

    public int getCritDamage()
    {
        return critDamage;
    }

    public int getAttack()
    {
        return attack;
    }

    public int getAccuracy()
    {
        return accuracy;
    }
}
