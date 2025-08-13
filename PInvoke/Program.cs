
// Amir Moeini Rad
// August 14, 2025

// Main Concept: P/Invoke (Platform Invocation Services) allows managed code to call unmanaged functions implemented in DLLs.


using System.Runtime.InteropServices;


namespace PInvoke
{
    internal class Program
    {
        // Declare the external function
        // Use 'DllImportAttribute' class to specify the DLL and the function signature.
        // 'user32.dll' is a Windows DLL that contains functions for creating and managing windows.
        // 'CharSet' is set to 'Unicode' to ensure proper string encoding.
        // 'MessageBox()' is a function that displays a message box with a specified text and caption.
        // 'MessageBox()' is defined with the 'extern' keyword to indicate that it is implemented externally. In other words,
        // it is not defined in this C# code but in the user32.dll library.
        // 'IntPtr' is used for the window handle, which is set to 'IntPtr.Zero' to indicate that the message box has no owner window.
        // 'IntPtr' is an alias for 'System.IntPtr', which is a platform-specific type that is used to represent a pointer or a handle.
        // 'text' is the message to be displayed in the message box.
        // 'caption' is the title of the message box.
        // 'type' is the type of message box to be displayed, which is set to 0 for a simple OK button message box.
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);


        static void Main()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("P/Invoke (Platform Invocation Services) in C#.NET...");
            Console.WriteLine("----------------------------------------------------\n");


            Console.WriteLine("Using an unmanaged resource (Windows native API) in C#.NET.");
            Console.WriteLine("Calling MessageBox() in user32.dll.");

            
            // Call the native function (Windows function)
            MessageBox(IntPtr.Zero, "Hello from C#!", "P/Invoke Demo", 0);


            Console.WriteLine("\nDone.");
        }
    }
}
