using Godot;
using System;

public partial class Camera : Camera3D
{
	private Vector2 rotation = Vector2.Zero;

	public float HorizontalSensitivity = 5.0f;
	public float VerticalSensitivity = 5.0f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Basis = Basis.Identity;
		RotateObjectLocal(Vector3.Up, rotation.X);
		RotateObjectLocal(Vector3.Right, rotation.Y);
	}

	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventMouseMotion mouseMotion)
		{
			rotation.X += mouseMotion.Relative.X * (float)GetProcessDeltaTime();
			rotation.Y += mouseMotion.Relative.Y * (float)GetProcessDeltaTime();
		}
	}
}
