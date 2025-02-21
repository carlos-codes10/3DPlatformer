using UnityEngine;

[CreateAssetMenu(menuName ="Player Stats")]
public class PlayerStats : ScriptableObject
{
    public int health;
    public int maxHealth;
    public int moveSpeed;
    public int jumpForce;
    public int gravity;

}
