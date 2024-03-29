﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BreakTime
{
    public sealed class KeyboardHook : IDisposable
    {
        // Registers a hot key with Windows.
        // Регистрация Горячей клавиши в Windows 
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        // Unregisters the hot key with Windows.
        // Снятие регистрации с горячей клавиши в Windows
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        Logger logger;

        private class Window : NativeWindow, IDisposable
        {
            private static int WM_HOTKEY = 0x0312;

            public Window()
            {
                // create the handle for the window.
                this.CreateHandle(new CreateParams());
            }

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                // check if we got a hot key pressed.
                // Проверяем, если нажаты горячие клавиши
                if (m.Msg == WM_HOTKEY)
                {
                    // get the keys.
                    // Определяем какие клавиши нажаты
                    Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                    ModKey modifier = (ModKey)((int)m.LParam & 0xFFFF);

                    // invoke the event to notify the parent.
                    // Сообщаем, что нажаты горячие клавиши, и передаем, какие клавиши были нажаты в соответствующий класс
                    if (KeyPressed != null)
                        KeyPressed(this, new KeyPressedEventArgs(modifier, key));
                }
            }

            public event EventHandler<KeyPressedEventArgs> KeyPressed;

            #region IDisposable Members

            public void Dispose()
            {
                this.DestroyHandle();
            }

            #endregion
        }

        private Window _window = new Window();
        private int _currentId;

        public KeyboardHook()
        {
            // register the event of the inner native window.
            _window.KeyPressed += delegate (object sender, KeyPressedEventArgs args)
            {
                if (KeyPressed != null)
                    KeyPressed(this, args);
            };
        }

        public void AddLogger(Logger addLogger)
        {
            logger = addLogger;
        }

        public void RegisterHotKey(ModKey modifier, Keys key)
        {
            // increment the counter.
            _currentId = _currentId + 1;

            // register the hot key.
            if (!RegisterHotKey(_window.Handle, _currentId, (uint)modifier, (uint)key))
                throw new InvalidOperationException("Couldn’t register the hot key.");
            else
                if (logger != null)
                    logger.Write("Hotkey " + modifier.ToString() + " + " + key.ToString() + " registered", Logger.Layers.Hotkeys);
        }

        public event EventHandler<KeyPressedEventArgs> KeyPressed;

        #region IDisposable Members

        public void Dispose()
        {
            // unregister all the registered hot keys.
            for (int i = _currentId; i > 0; i--)
            {
                UnregisterHotKey(_window.Handle, i);
            }

            // dispose the inner native window.
            _window.Dispose();
        }

        #endregion
    }

    public class KeyPressedEventArgs : EventArgs
    {
        private ModKey _modifier;
        private Keys _key;

        internal KeyPressedEventArgs(ModKey modifier, Keys key)
        {
            _modifier = modifier;
            _key = key;
        }

        public ModKey Modifier
        {
            get { return _modifier; }
        }

        public Keys Key
        {
            get { return _key; }
        }
    }

    [Flags]
    public enum ModKey : uint
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Win = 8
    }
}
