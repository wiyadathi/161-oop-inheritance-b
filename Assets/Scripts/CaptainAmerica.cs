using UnityEngine;

class CaptainAmerica : SuperHero
{
    public CaptainAmerica(string newName, int newHp, string newSuitColor)
        : base(newName, newHp, newSuitColor)
    {
    }

    public void LeapAndJump()
    {
        Debug.Log($"\t {Name}: is LeapAndJump");
    }

    public void ThrowShield()
    {
        Debug.Log($"\t {Name}: is ThrowShield");
    }
}
