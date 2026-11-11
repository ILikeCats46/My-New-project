using UnityEngine;

public class sphere : MonoBehaviour
{
    
    public float speed = 10.0f;

    private float power = 100f;
    public GameObject enemyOne;
    [SerializeField] //attribute
    


    private bool hassword = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
      
    }

    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
            float translation = Input.GetAxis("Horizontal") * speed;
        float jumping = Input.GetAxis("Vertical") * speed;
        translation *= Time.deltaTime; //this is a static
        jumping *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Translate(0, jumping, 0);




    }

    void OnMouseOver()
    {

        Debug.Log("Sphere.");
    }

    private void OnTriggerEnter(Collider other) //event
    {

        

        if (hassword)
        {
           
            Debug.Log("enemy dies");

           
        }

    }
}
