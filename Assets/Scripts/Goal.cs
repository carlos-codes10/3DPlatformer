using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger!");
        SceneManager.LoadScene("Victory");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
