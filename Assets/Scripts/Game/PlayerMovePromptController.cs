using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovePromptController : MonoBehaviour
{
    public Player player;
    public Enemy enemy;

    public Controller_Game gameController;

    public void PlayerAttack()
    {
        gameController.ToggleMovePrompt();

        int damage = player.getAttack();
        bool isCrit = false;

        int crit = Random.Range(1, 100);
        int hit = Random.Range(1, 100);

        if (crit >= player.getCritRate())
        {
            damage *= player.getCritDamage();
        }

        if(hit >= player.getAccuracy())
        {
            enemy.DamageEnemy(damage);
            Debug.Log("Enemy was damaged " + damage + " HP!");
            //TODO: Add hitting animation;
            //Use bool "isCrit" to trigger an extra "Critical hit!" text animation.
        }

        enemy.EnemyAttack();
    }

    public void UseBag()
    {

    }

    public void MagicAttack()
    {

    }

    public void Escape()
    {

    }

    public void UseBurst()
    {
        if(player.getElementalEnergy() >= player.getRequiredElementalEnergy())
        {
            Debug.Log("Cast Burst");
            player.setElementalEnergy(0);
        } else
        {
            Debug.Log("Insufficient Energy! You need " + player.getRequiredElementalEnergy() + " Energy, but you only have " + player.getElementalEnergy() + " Energy!");
        }
    }
}
