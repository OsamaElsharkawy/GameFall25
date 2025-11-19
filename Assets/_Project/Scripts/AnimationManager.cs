using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public static AnimationManager Instance;
    public Animator doorAnimator;

    private void Awake()
    {
        if (doorAnimator == null)
        {
            Debug.LogError("DoorAnimator: no Animator found!");
        }

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        // If you want this manager to presist across scenes (Uncomment)
        //DontDestroyOnLoad(gameObject);
    }

    [ContextMenu("OpenDoor")]
    public void OpenDoor()
    {
        doorAnimator.SetBool("isOpen", true);
    }

    [ContextMenu("CloseDoor")]
    public void CloseDoor()
    {
        doorAnimator.SetBool("isOpen", false);
    }

    // Alternative Approach
    public void ToggleDoor()
    {
        bool current = doorAnimator.GetBool("isOpen");
        doorAnimator.SetBool("isOpen", !current);
    }
}
