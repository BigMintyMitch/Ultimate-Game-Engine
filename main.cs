using System;
using System.IO;
using System.Threading;

using UltimateEngine;
using Game;

class MainClass {
	static MainClass(){
		Debug.Reset();
		Console.CursorVisible = false;
	}

	public static void Main (string[] args) {
		Scene scene = new Scene(100, 20);

		Camera cam = new Camera();

		Player p = new Player();

		Animator animator = p.Animator;

		animator.Add(Animation.FromFile("C:\\Users\\Me\\source\\repos\\Ultimate-Game-Engine\\Game\\Animations\\Running.anim"));
		animator.Add(Animation.FromFile("C:\\Users\\Me\\source\\repos\\Ultimate-Game-Engine\\Game\\Animations\\Jumping.anim"));
		animator.Add(Animation.FromFile("C:\\Users\\Me\\source\\repos\\Ultimate-Game-Engine\\Game\\Animations\\Idle.anim"));

		GameObject ground = new GameObject("Ground", new Image(new string[] { new string('^', 200) }));
		ground.AddComponent(new Collider());
		ground.Tag = "Ground";

		GameObject plat1 = new GameObject("Platform 1", new Image(new string[] { new string('^', 20) }));
		plat1.AddComponent(new Collider());
		plat1.Tag = "Ground";

		GameObject plat2 = new GameObject("Platform 2", new Image(new string[] { new string('^', 20) }));
		plat2.AddComponent(new Collider());
		plat2.Tag = "Ground";

		GameObject plat3 = new GameObject("Platform 3", new Image(new string[] { new string('^', 20) }));
		plat3.AddComponent(new Collider());
		plat3.Tag = "Ground";

		GameObject box = new GameObject("Box", new Image(new string[]
		{
			"XXX",
			"XXX",
			"XXX"
		}));

		scene.Instantiate(p, new Point(2, 1));

		scene.Instantiate(ground, new Point(-50, 0));
		scene.Instantiate(plat1, new Point(20, 7));
		scene.Instantiate(plat2, new Point(40, 14));
		scene.Instantiate(plat3, new Point(70, 14));

		scene.Instantiate(box, new Point(13, 1));

		scene.Instantiate(cam);

		scene.Run();

		//Ensure that the program does not end any time soon
		Thread.Sleep(int.MaxValue);
	}
}