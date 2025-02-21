using UnityEngine;

public class Hazard : MonoBehaviour
{
    Player p;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        p = FindAnyObjectByType<Player>();
    }
    private void OnCollisionEnter(Collision collsion)
    {
        Debug.Log("Collsion!");
        p.Damage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
