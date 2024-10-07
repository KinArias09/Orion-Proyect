using UnityEngine;
using UnityEngine.SceneManagement;

public class controlMenu : MonoBehaviour
{
    public void Cargarboton(string nombreBoton)
    {
        SceneManager.LoadScene(nombreBoton);
    }

}

