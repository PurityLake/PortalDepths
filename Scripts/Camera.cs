using Godot;
using System;

public partial class Camera : Camera3D
{
	private Vector3 mouseDelta = new Vector3(0, 0, 0);

	public float HorizontalSensitivity = 5.0f;
	public float VerticalSensitivity = 5.0f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public override void _Input(InputEvent @event)
    {
		if (@event is InputEventMouseMotion mouseMotion)
		{
			mouseDelta.X += mouseMotion.Relative.X * (float)GetProcessDeltaTime();
			mouseDelta.Y += mouseMotion.Relative.Y * (float)GetProcessDeltaTime();
		}
    }
}
