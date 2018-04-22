using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockSpawner : MonoBehaviour {

	public GameObject blockPrefab;
	public int baseNumberOfBlocks;
	public GameObject player;
	public Text scoreText;
	public Text levelText;

	private int level;
	private int currentNumberOfBlocks;
	private int score;

	// Use this for initialization
	void Start () {
		level = 1;
		currentNumberOfBlocks = 0;
		score = 0;

		SetScoreText();
		SetLevelText();

		createBlocks();
	}

	void createBlocks()
	{
		currentNumberOfBlocks = 0;

		for (int i = 0; i < baseNumberOfBlocks * level; i++)
		{
			int xzRange = 7;
			if (level <= xzRange)
			{
				xzRange = level;
			}
			// Random position
			var spawnPosition = new Vector3(
				Random.Range(-1 * xzRange, 1 * xzRange),
				Random.Range(0, level),
				Random.Range(-1 * xzRange, 1 * xzRange));

			// Correct y position so it sits on the plane correctly
			spawnPosition.y -= 0.5f;

			// Make sure blocks aren't sitting on the Player
			if (spawnPosition.x == Mathf.Ceil(player.transform.position.x) || spawnPosition.x == Mathf.Floor(player.transform.position.x))
			{
				spawnPosition.x++;
			}

			if (spawnPosition.z == Mathf.Ceil(player.transform.position.z) || spawnPosition.z == Mathf.Floor(player.transform.position.z))
			{
				spawnPosition.z++;

			}

			// Fixed rotation
			var spawnRotation = new Quaternion(
				0,
				0,
				0,
				0);

			Instantiate(blockPrefab, spawnPosition, spawnRotation);

			currentNumberOfBlocks++;
		}

		Debug.Log("Level: " + level + " Blocks: " + currentNumberOfBlocks);
	}

	public void BlockDestroyed(int multiplier)
	{
		currentNumberOfBlocks--;
		score += multiplier;
		SetScoreText();

		if (currentNumberOfBlocks == 0)
		{
			level++;
			SetLevelText();
			createBlocks();
		}
	}

	void SetScoreText()
	{
		scoreText.text = "Score: " + score.ToString();
	}

	void SetLevelText()
	{
		levelText.text = "Level: " + level.ToString();
	}
}
