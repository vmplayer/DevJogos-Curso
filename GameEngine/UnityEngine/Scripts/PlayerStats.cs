using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100; // Vida máxima
    public int currentHealth; // Vida atual do personagem
    public int score = 0; // Pontuação do jogador

    public Slider healthBar; // Referência à barra de vida
    public TMP_Text scoreText; // Referência ao texto de pontuação
     public Image healthBarFill; // A parte que preenche a barra para alterar a cor

     private Color originalColor; //Cor original da barra
     private bool isFlashing = false; //Controla se está piscando ou não
     private float flashDuration = 0.2f; //Duração do efeito de piscar

    void Start()
    {
        // Define a vida inicial como o valor máximo
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
        //Guarda a cor original da barra
        originalColor = healthBarFill.color;

        UpdateScoreText();
    }

    // Método para atualizar a vida
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Garante que a vida não fique negativa
        healthBar.value = currentHealth;

        // Se a vida ainda está acima de zero e não está piscando, inicie o efeito
        if(currentHealth > 0 && !isFlashing)
        {
            StartCoroutine(FlashRed());
        }
    }

    // Método para adicionar pontos
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Atualiza o texto da pontuação
    void UpdateScoreText()
    {
        scoreText.text = "Pontuação: " + score;
    }

    //Corrotina para fazer a barra piscar em vermelho
    private IEnumerator FlashRed()
    {
        isFlashing = true; //Define como piscando
        healthBarFill.color = Color.red; //Muda a cor para vermelho

        yield return new WaitForSeconds(flashDuration); //Aguarda o tempo da piscada
        isFlashing = false; //Define como não piscando
    }
}
