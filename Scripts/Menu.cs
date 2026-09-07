using Godot;

public partial class Menu : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Pressed += BotaoClicado;
	}

	private void BotaoClicado()
	{
		GetTree().ChangeSceneToFile("res://Scenes/CenaInicial.tscn");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
