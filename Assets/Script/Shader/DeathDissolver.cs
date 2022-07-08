using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDissolver : MonoBehaviour
{
    //Publics
    [Tooltip("Der Wert der sich Pro Tock verändert")]
    public float change = 0.1f;
    [Tooltip("Der Wert wie oft das ganze Tockt")]
    public float repeatingPerSecond;
    public Material _Mat;

    //Privates
    private bool isDying;
    private float shaderValue;

    // Start is called before the first frame update
    void Start()
    {   
        if (TryGetComponent(out MeshRenderer renderer))
            _Mat = renderer.material;
        else
        {
            Debug.LogError(message: "Sent help plz :c");
        }

        ShaderDying();
    }

    public void ShaderDying()
    {
        isDying = true;
        shaderValue = 1;
        InvokeRepeating("ChangeShader", 0, repeatingPerSecond);
    }

    public void ShaderSpawning()
    {
        isDying = false;
        shaderValue = 0;
        InvokeRepeating("ChangeShader", 0, repeatingPerSecond);
    }

    void ChangeShader()
    {
        if (shaderValue <= 0f && isDying == true)
        {
            CancelInvoke();
        }
        else if(shaderValue > 1f && isDying == false)
        {
            CancelInvoke();
        }
        else if (this.gameObject.GetComponent<MeshRenderer>().material = _Mat)
        {
            if (isDying == true)
            {
                if (shaderValue - change > 0)
                {
                    shaderValue -= change;
                    _Mat.SetFloat("_death", shaderValue);
                }
            }
            else
            {
                if(shaderValue + change <= 1.1)
                {
                    shaderValue += change;
                    _Mat.SetFloat("_death", shaderValue);
                }
            }
        }
    }
}

