using System;

namespace EventImplementation
{
    //public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    public class Dispatcher
    {
        private string name;

        //public event NameChangeEventHandler nameChange;
        public event EventHandler<NameChangeEventArgs> nameChange;
        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
                this.OnNameChanged(new NameChangeEventArgs(value));
            }
        }
        public void OnNameChanged(NameChangeEventArgs args)
        {
            nameChange.Invoke(this, args);
        }
    }
}
