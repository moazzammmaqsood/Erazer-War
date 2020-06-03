using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
	// Start is called before the first frame update


	[HideInInspector]
	public GameObject player;
	[HideInInspector]
	public GameObject enemy;
	public PlayerModelClass playerclass;
	public EnemyModelClass enemyclass;
	public Material[] skins;
	public bool playerturn;
	Renderer render;
	public TextMeshProUGUI playerScoreText;
	public TextMeshProUGUI enemyScoreText;
	public Transform playerSpawn;
	public Transform enemySpawn;

	[HideInInspector]
	public int startScore = 0;
	[HideInInspector]
	public int playerScore = 0;
	[HideInInspector]
	public int enemyScore = 0;

	private GameObject playerContainer;
	private GameObject enemyContainer;

	private Rigidbody playerRB;
	private Rigidbody enemyRB;
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		enemy = GameObject.FindGameObjectWithTag("Enemy");

		playerRB = player.GetComponent<Rigidbody>();
		enemyRB = enemy.GetComponent<Rigidbody>();

		playerContainer = GameObject.FindGameObjectWithTag("playerContainer");
		enemyContainer = GameObject.FindGameObjectWithTag("enemyContainer");
		render = player.GetComponent<Renderer>();
		render.enabled = true;
		render.sharedMaterial = getskin(1);
		playerturn = true;
		playerScoreText.text = startScore.ToString();
		enemyScoreText.text = startScore.ToString();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void gamestart()
	{



	}
	public void Restart()
	{

	}

	public void Pause()
	{

	}

	public void End()
	{

	}

	public Material getskin(int i)
	{

		return skins[i];
	}

	public void increamentPlayerScore()
	{
		playerScoreText.text = (++playerScore).ToString();
		respawnPlayers();
	}

	public void increamentEnemyScore()
	{
		enemyScoreText.text = (++enemyScore).ToString();
		respawnPlayers();
	}

	private void respawnPlayers()
	{
		playerContainer.transform.position = playerSpawn.position;
		playerContainer.transform.rotation = playerSpawn.rotation;
		enemyContainer.transform.position = enemySpawn.position;
		enemyContainer.transform.rotation = enemySpawn.rotation;
		playerRB.velocity = new Vector3(0, 0, 0);
		enemyRB.velocity = new Vector3(0, 0, 0);
	}

}
