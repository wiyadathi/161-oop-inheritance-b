using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    IronMan ironMan = new IronMan("Tony", 100, "Red");
    CaptainAmerica captainAmerica = new CaptainAmerica("Steven", 100, "Blue");

    // Start is called before the first frame update
    void Start()
    {
        ironMan.Name = "";

        // Show Attributes
        Debug.Log($"IronMan name: {ironMan.Name}, HP: {ironMan.Hp}, color: {ironMan.SuitColor}");
        Debug.Log($"CaptainAmerica name: {captainAmerica.Name}, HP: {captainAmerica.Hp}, color: {captainAmerica.SuitColor}");

        ironMan.UpdateArmor(5.25f);
        captainAmerica.UpdateArmor(5.5f);
    }

    private void Update()
    {
        if (ironMan.IsDead() || captainAmerica.IsDead())
        {
            return;
        }

        // Iron Man turn
        int randomDamage = Random.Range(10, 21);
        ironMan.ShootLaser();
        captainAmerica.TakeDamege(randomDamage);

        // Captain America turn
        randomDamage = Random.Range(10, 21);
        captainAmerica.ThrowShield();
        ironMan.TakeDamege(randomDamage);
    }
}
