<p align="center">
  <img alt="Title" src="./Assets/Title.png" />
</p>

In this example, you can see how to use CsWin32 under WinUI to show a Trayicon with a modern MenuFlyout.

It supports unpackaged applications. I don't know why I can't support aot well. It may be solved later.

## How can I use it?

The main class is located in `WinUITrayIcon\Taskbar`. Copy _SystemTrayIcon_ and _SystemTrayIconWindow_ to your own project, and then call it like this:

```c#
private SystemTrayIcon? _trayIcon;

            _trayIcon = new SystemTrayIcon();
            _trayIcon.Show();
```

Want more customization? Please check TODO in the code.
