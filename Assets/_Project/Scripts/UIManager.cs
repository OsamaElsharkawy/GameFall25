using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Singleton (simple pattern)
    public static UIManager Instance;

    public Slider slider;
    public Button btn;

    // Optional: starting FOV or default slider value
    [Header("Camera")]
    [Tooltip("If left zero, Camera.main.fieldOfView will be used on Start")]
    public float defaultFOV = 0f;

    private void Awake()
    {
        // Enforce singleton
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        // If you want this manager to persist across scenes uncomment:
        // DontDestroyOnLoad(gameObject);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Safety checks before subscribing
        if (slider == null) Debug.LogError("UIManager: Slider reference is null. Assign in Inspector.");
        if (btn == null) Debug.LogError("UIManager: Button reference is null. Assign in Inspector.");

        // Subscribe to UI events
        slider.onValueChanged.AddListener(ChangeCameraFOV);
        btn.onClick.AddListener(DisableSlider);
    }

    // Called by Slider (float between slider.minValue and slider.maxValue)
    public void ChangeCameraFOV(float _fov)
    {
        if (Camera.main != null)
        {
            Camera.main.fieldOfView = _fov;
            Debug.Log("FOV: " + _fov);
        }
        else
        {
            Debug.LogWarning("ChangeCameraFOV: No Camera.main found in scene.");
        }
    }

    // Toggle slider visibility
    public void DisableSlider()
    {
        slider.gameObject.SetActive(!slider.gameObject.activeInHierarchy);
    }
}