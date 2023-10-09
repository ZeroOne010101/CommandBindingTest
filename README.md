## I ~~have~~ had the following problems with AvaloniaUI:

1. The Close Button of my TestWindow is inactive. My best guess is that the binding fails, since the constructor of TestViewModel does not seem to run.

2. There has to be a better way of handling windows than my current hack with WindowDict in App.axml.cs. Avalonia has keep track of them *somewhere*

3. Why does the Destructor function on my TestWindow not get called? It seems like that should happen when the window gets closed.

## User "Lance Chung" in the AvaloniaUI Telegram Group helped me out with the following answer:

1. You must set the actual DataContext of the TestWindow so the Command could be binded successfully.

3. I don't know about the destructor but you can use the override method of the Window (void OnClosing(WindowClosingEventArgs e)) instead.

Thank you very much! :D


This Repository will shortly be archived to preserve the problem & soluton in case anyone finds themselves in the same situation.
