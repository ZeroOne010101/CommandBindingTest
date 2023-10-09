## I have the following problems:

1. The Close Button of my TestWindow is inactive. My best guess is that the binding fails, since the constructor of TestViewModel does not seem to run.

2. There has to be a better way of handling windows than my current hack with WindowDict in App.axml.cs. Avalonia has keep track of them *somewhere*

3. Why does the Destructor function on my TestWindow not get called? It seems like that should happen when the window gets closed.
