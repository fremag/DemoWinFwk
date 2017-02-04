using System;
using System.Diagnostics;
using WinFwk.UICommands;
using WinFwk.UIModules;

namespace DemoWinFwk
{
    public class StringTypedUiCommand : AbstractTypedUICommand<String>
    {
        public StringTypedUiCommand() : base("String", "Some string", "Data", null)
        {
        }

        public override void HandleAction(string data)
        {
            Debug.WriteLine(GetType());
        }
    }

    public class TextTypedUiCommand : AbstractTypedUICommand<String>
    {
        public TextTypedUiCommand() : base("Text", "Some text", "Text", null)
        {
        }

        public override void HandleAction(string data)
        {
            Debug.WriteLine(GetType());
        }
    }

    public class DoubleTypedUiCommands : AbstractTypedUICommand<MyDouble>
    {
        public DoubleTypedUiCommands() : base("Double", "Some double", "Data", null)
        {
        }

        public override void HandleAction(MyDouble data)
        {
            Debug.WriteLine(GetType());
        }
    }

    public class MyDouble
    {
        double Data { get; }
    }

    public class TotoCommand : AbstractVoidUICommand
    {
        public TotoCommand() : base("Toto", "toto command", "File", null)
        {
        }

        public override void Run()
        {
            MessageBus.SendMessage(new DockRequest(new StringModule()));
        }
    }
}