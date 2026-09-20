using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logicScript;
 
    void Start() 
    { 
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    void Update() 
    { 
        
    }
 
    private void OnTriggerEnter2D(Collider2D other) 
    { 
        logicScript.addScore();
    }
}
