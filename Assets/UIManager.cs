using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Material clippingPlaneMaterial;
    public GameObject parentPlane;

    public Slider rotSpeedSlider;
    public Button axisX;
    public Button axisY;
    public Button axisZ;

    private bool isX = false;
    private bool isY = false;
    private bool isZ = false;

    public Button colorGreen;
    public Button colorRed;
    public Button colorBlue;

    private void Awake()
    {
        colorGreen.onClick.AddListener(delegate { SetCSColorGreen(); });
        colorRed.onClick.AddListener(delegate { SetCSColorRed(); });
        colorBlue.onClick.AddListener(delegate { SetCSColorBlue(); });

        axisX.onClick.AddListener(delegate { SetAxisX(); });
        axisY.onClick.AddListener(delegate { SetAxisY(); });
        axisZ.onClick.AddListener(delegate { SetAxisZ(); });
    }

    public void SetAxisX()
    {
        isX = true;
        isY = false;
        isZ = false;
    }
    public void SetAxisY()
    {
        isX = false;
        isY = true;
        isZ = false;
    }
    public void SetAxisZ()
    {
        isX = false;
        isY = false;
        isZ = true;
    }

    public void SetCSColorGreen()
    {
        clippingPlaneMaterial.SetColor("_CrossSectionColor", new Color(255f, 0f, 217f, 1f));
    }

    public void SetCSColorRed()
    {
        //create a new color using #00FFF800

        clippingPlaneMaterial.SetColor("_CrossSectionColor", new Color(0f, 255f, 248f, 1f));
    }

    public void SetCSColorBlue()
    {
        clippingPlaneMaterial.SetColor("_CrossSectionColor", new Color(195f, 255f, 0f, 1f));
    }

    void Update()
    {
        if (isX)
        {
            Vector3 currentRotation = parentPlane.transform.rotation.eulerAngles;
            parentPlane.transform.rotation *= Quaternion.Euler(-rotSpeedSlider.value, 0, 0);
        }
        else if (isY)
        {
            Vector3 currentRotation = parentPlane.transform.rotation.eulerAngles;
            parentPlane.transform.rotation *= Quaternion.Euler(0, -rotSpeedSlider.value, 0);
        }
        else if (isZ)
        {
            Vector3 currentRotation = parentPlane.transform.rotation.eulerAngles;
            parentPlane.transform.rotation *= Quaternion.Euler(0, 0, -rotSpeedSlider.value);
        }

    }
}
