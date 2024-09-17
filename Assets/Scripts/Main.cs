using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Build oject
        IronMan ironMan = new IronMan("Tony",100,"Red");
        CaptainAmerica captainAmerica = new CaptainAmerica("Steven",100,"Blue");

        // Random damage
        int randomDamage;

        // Show Attributes
        Debug.Log($"IronMan name: {ironMan.Name}, HP: {ironMan.Hp}, color: {ironMan.SuitColor}");
        Debug.Log($"CaptainAmerica name: {captainAmerica.Name}, HP: {captainAmerica.Hp}, color: {captainAmerica.SuitColor}");

        ironMan.UpdateAmrmor(5.25f);
        captainAmerica.UpdateAmrmor(5.5f);

        for (int i = 0; i < 5; i++)
        {
            // Iron Man turn
            randomDamage = Random.Range(10, 21);
            ironMan.ShootLaser();
            captainAmerica.TakeDamege(randomDamage);

            // Captain America turn
            randomDamage = Random.Range(10, 21);
            captainAmerica.ThrowShield();
            ironMan.TakeDamege(randomDamage);
        }

        
    }
}
