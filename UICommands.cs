using System;
using System.Diagnostics;
using System.Windows.Forms;
using WinFwk.UICommands;
using WinFwk.UIModules;

namespace DemoWinFwk
{
    public class StringTypedUiCommand : AbstractDataUICommand<string>
    {
        public StringTypedUiCommand() : base("String", "Some string", "Data", null)
        {
        }

        protected override void HandleData(string data)
        {
            MessageBox.Show("String: "+data);
        }
    }

    public class TextTypedUiCommand : AbstractDataUICommand<string>
    {
        public TextTypedUiCommand() : base("Text", "Some text", "Text", null)
        {
        }

        protected override void HandleData(string data)
        {
            MessageBox.Show("Text: " + data);
        }
    }

    public class DoubleTypedUiCommands : AbstractDataUICommand<MyDouble>
    {
        public DoubleTypedUiCommands() : base("Double", "Some double", "Data", null)
        {
        }

        protected override void HandleData(MyDouble data)
        {
            MessageBox.Show($"{data.GetType()}: {data.Data}");

        }
    }

    public class MyDouble
    {
        public double Data { get; set; }
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