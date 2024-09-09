Creating a keyboard hook in C# involves using the Windows API to capture keyboard events globally. Here's a simple example to get you started:

1. **Add the necessary imports**:
   ```csharp
   using System;
   using System.Diagnostics;
   using System.Runtime.InteropServices;
   using System.Windows.Forms;
   ```

2. **Define the necessary constants and structures**:
   ```csharp
   public class KeyboardHook
   {
       private const int WH_KEYBOARD_LL = 13;
       private const int WM_KEYDOWN = 0x0100;

       private LowLevelKeyboardProc _proc;
       private IntPtr _hookID = IntPtr.Zero;

       public KeyboardHook()
       {
           _proc = HookCallback;
       }

       public void Hook()
       {
           _hookID = SetHook(_proc);
       }

       public void Unhook()
       {
           UnhookWindowsHookEx(_hookID);
       }

       private IntPtr SetHook(LowLevelKeyboardProc proc)
       {
           using (Process curProcess = Process.GetCurrentProcess())
           using (ProcessModule curModule = curProcess.MainModule)
           {
               return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
           }
       }

       private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

       private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
       {
           if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
           {
               int vkCode = Marshal.ReadInt32(lParam);
               Console.WriteLine((Keys)vkCode);
           }
           return CallNextHookEx(_hookID, nCode, wParam, lParam);
       }

       [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
       private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

       [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
       [return: MarshalAs(UnmanagedType.Bool)]
       private static extern bool UnhookWindowsHookEx(IntPtr hhk);

       [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
       private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

       [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
       private static extern IntPtr GetModuleHandle(string lpModuleName);
   }
   ```

3. **Use the hook in your application**:
   ```csharp
   class Program
   {
       static void Main(string[] args)
       {
           KeyboardHook kh = new KeyboardHook();
           kh.Hook();
           Application.Run();
           kh.Unhook();
       }
   }
   ```

This code sets up a global keyboard hook that captures key presses and prints them to the console. Make sure to run your application with appropriate permissions, as hooks can require elevated privileges.

For more detailed examples and explanations, you can check out resources like [CodeProject](https://www.codeproject.com/Articles/19004/A-Simple-C-Global-Low-Level-Keyboard-Hook)⁵ or GitHub repositories⁴.

Feel free to ask if you have any questions or need further assistance!

Sursă: conversație cu Copilot. 9/9/2024
(1) A Simple C# Global Low Level Keyboard Hook - CodeProject. https://www.codeproject.com/Articles/19004/A-Simple-C-Global-Low-Level-Keyboard-Hook.
(2) a global keyboard hook library for .net windows application.. https://github.com/ikst/Ikst.KeyboardHook.
(3) C# Class Library Tutorial - Create Global Keyboard Hook DLL - Part 1. https://www.youtube.com/watch?v=rZPw87iGdLo.
(4) C# - System-wide Global Hotkeys (using keyboard hooks) (and WPF). https://www.youtube.com/watch?v=qLxqoh1JLnM.
(5) C# Class Library Tutorial - Create Global Keyboard Hook DLL - Part 2. https://www.youtube.com/watch?v=-2sypfmYXD4.
(6) rvknth043/Global-Low-Level-Key-Board-And-Mouse-Hook. https://github.com/rvknth043/Global-Low-Level-Key-Board-And-Mouse-Hook.
(7) undefined. https://www.nuget.org/packages/Ikst.KeyboardHook/.
(8) github.com. https://github.com/JosBijlenga/PlaybackChanger/tree/18f2b912d5d1a29b88d40f0d3327c408d66efc95/Playback_Changer%2FHelpers%2FKeyboardHook.cs.
(9) github.com. https://github.com/CedricBaetens/GO-Radio/tree/812e0d3114bcdcae08362b0d1c179c09b7689ce8/_legacy%2FGO%20Radio%2FClasses%2FKeyboardHook.cs.
(10) github.com. https://github.com/Leo-Neumuller/WakMultiAccount/tree/a37a17426aaf9b49fc1fd7bce962086390b90885/MultiAccount%2Fhandle_key.cs.
(11) github.com. https://github.com/kin9pin/ClipboardToClipboard/tree/d11d445b7a5993c6d4dc359d1963cb106c57e04a/ClipboardToClipboard%2FClipboardToClipboard%2FProgram.cs.
(12) github.com. https://github.com/bluepope/WinStudy/tree/c37c132ebb78b3d9d1300c34b150015949e1152e/ConsoleKeyHooker%2FProgram.cs.
(13) github.com. https://github.com/RBernhardt/unisono/tree/348696fb1059c6982225a8b257abb0db4a5b8a47/unisono-ui%2Futils%2FKeyboardManager.cs.