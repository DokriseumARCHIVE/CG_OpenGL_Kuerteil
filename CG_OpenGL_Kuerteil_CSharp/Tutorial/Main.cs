using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.Common;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common.Input;


namespace OpenGL_Kuerteil.Tutorial;

public class Main : GameWindow
{
    public Main(int width, int height, string title) : base(GameWindowSettings.Default, new NativeWindowSettings(){
        Title = title,
        Size = new Vector2i(width,height),
        WindowBorder = WindowBorder.Resizable,
        StartVisible = false,
        StartFocused = true,
        WindowState = WindowState.Normal,
        API = ContextAPI.OpenGL,
        Profile = ContextProfile.Core,
        APIVersion = new Version(3,3),
    })
    {
        CenterWindow();
    }

    protected override void OnResize(ResizeEventArgs e)
    {
        //GL.Viewport(0,0,e.Width,e.Height);
        //base.OnResize(e);
        base.OnResize(e);

        GL.Viewport(0, 0, e.Width, e.Height);
    }

    protected override void OnLoad()
    {
        IsVisible = true;
        //ImageResult loadedIcon;
        //using (Stream stream = File.OpenRead("../../../icon.png"))
        //{
            //loadedIcon = ImageResult.FromStream(stream, ColorComponents.RedGreenBlueAlpha);
        //}

        //Image _icon = new Image(loadedIcon.Width, loadedIcon.Height, loadedIcon.Data);
        //Icon = new WindowIcon(_icon);
        //base.OnLoad();
        base.OnLoad();

        GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
    }

    protected override void OnRenderFrame(FrameEventArgs e)
    {
        base.OnRenderFrame(e);

        GL.Clear(ClearBufferMask.ColorBufferBit);

        //Code goes here.

        SwapBuffers();
    }
}