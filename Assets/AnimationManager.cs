using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public static AnimationManager Instance;

    public List<string> movementAnim = new List<string>();
    public List<string> slotAnim = new List<string>();

    public bool isLevelSelection = false;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
}
