using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField]public InputManager InputManager { get; private set; }

    private void OnEnable()
    {
        DontDestroyOnLoad(this);
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void OnDisable()
    {
        if(Instance == this) Instance = null;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
