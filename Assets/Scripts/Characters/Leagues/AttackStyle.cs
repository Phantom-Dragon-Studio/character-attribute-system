using UnityEngine;

[CreateAssetMenu(fileName ="New Attack Style",menuName = "Phantom Dragon Studio/AttackStyle_File", order =2)]
[System.Serializable]
public abstract class AttackStyle : ScriptableObject, IAttackStyle
{
    public void BasicAttack()
    {
        //Play Animation
        //Do some maths
        //Deal Some Damage
    }

    public void ChargeAttack()
    {
        throw new System.NotImplementedException();
    }

    public void SpecialAttack()
    {
        throw new System.NotImplementedException();
    }
}
