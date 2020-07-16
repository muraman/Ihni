using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

	public int maxHealth = 20;
	public int currentHealth;

	public HealthBar healthBar;

    void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

	void Update()
	{
		if(currentHealth <= 0)
		{
			Die();
		}
	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
	
	public void Die()
	{
        SceneManager.LoadScene("Death");
		Time.timeScale = 0;
	}

}