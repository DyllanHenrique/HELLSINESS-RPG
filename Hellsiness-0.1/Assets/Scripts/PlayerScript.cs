using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject jogador;
    public float VelocidadeAndar;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(x, 0, y);
        
        rb.linearVelocity = direcao * VelocidadeAndar;
    }
}
