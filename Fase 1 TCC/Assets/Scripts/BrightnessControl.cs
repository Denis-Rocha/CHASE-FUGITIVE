using UnityEngine;
using UnityEngine.UI;

public class BrightnessControl : MonoBehaviour
{
    public Slider brightnessSlider;
    public Material brightnessMaterial; // Material de pós-processamento

    void Start()
    {
        brightnessSlider.onValueChanged.AddListener(UpdateBrightness);
    }

    void UpdateBrightness(float value)
    {
        brightnessMaterial.SetFloat("_Brightness", value); // Ajuste a propriedade correta do material
    }
}
