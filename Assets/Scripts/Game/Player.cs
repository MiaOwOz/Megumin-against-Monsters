using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health;
    private int elementalEnergy;
    private int requiredElementalEnergy;

    private int attack;
    private int critRate;
    private int critDamage;
    private int accuracy;

    public GameObject burstEmptyImage,
                      burstFullButton;

    // Start is called before the first frame update
    void Start()
    {
        health = 10_000;
        elementalEnergy = 0;
        requiredElementalEnergy = 100;
        accuracy = 75;

        critRate = 35;
        critDamage = 2;

        attack = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        toggleBurst();
    }

    // Damage Methods
    public void DamagePlayer(int damage)
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

    // Getters and Setters for Elemental Energy
    public int getElementalEnergy()
    {
        return elementalEnergy;
    }

    public void setElementalEnergy(int amount)
    {
        elementalEnergy = amount;
    }

    public void addElementalEnergy(int amount)
    {
        setElementalEnergy(getElementalEnergy() + amount);
    }

    public void removeElementalEnergy(int amount)
    {
        setElementalEnergy(getElementalEnergy() - amount);
    }

    public int getRequiredElementalEnergy()
    {
        return requiredElementalEnergy;
    }

    private void toggleBurst()
    {
        burstEmptyImage.SetActive(!(getElementalEnergy() >= requiredElementalEnergy));
        burstFullButton.SetActive((getElementalEnergy() >= requiredElementalEnergy));
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
