using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider slider;
    public Button btn;

    private float fov;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.onValueChanged.AddListener(ChangeCameraFOV);
        btn.onClick.AddListener(DisableSlider);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCameraFOV(float _fov)
    {
        Camera.main.fieldOfView = _fov;
        Debug.Log("FOV: " + _fov);
    }

    public void DisableSlider()
    {
        slider.gameObject.SetActive(!slider.gameObject.activeInHierarchy);
    }
}
