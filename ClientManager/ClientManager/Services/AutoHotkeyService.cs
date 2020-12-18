using System;
using System.Collections.Generic;
using System.Text;
using AutoHotkey.Interop;

namespace ClientManager.Services
{
    static public class AutoHotkeyService
    {
        static public AutoHotkeyEngine engine; 
        static public AutoHotkeyEngine CreateEngine()
        {
             if(engine is null)
             {
                engine = new AutoHotkeyEngine();
                return engine;
             }
            else
            {
                return engine;
            }
        }

        static public void EnableAutoHotkey()
        {
            
        }

        static public void DisableAutoHotkey()
        {

        }
    }
}
