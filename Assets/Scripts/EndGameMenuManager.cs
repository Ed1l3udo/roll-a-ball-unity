using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenuManager : MonoBehaviour
{

    [SerializeField] private string nomeMenuPrincipal;

    public void menuPrincipal()
    {
        SceneManager.LoadScene(nomeMenuPrincipal);
    }

    public void JogarDeNovo()
    {
        string nomeCenaAtual = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(nomeCenaAtual);
    }
}
