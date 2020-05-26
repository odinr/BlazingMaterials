using System;

namespace BlazingMaterials.Components
{
    public partial class MwcDrawerState
    {
        public class Manager
        {
            public readonly MwcDrawerState State;

            public event Action OnStateChanged;

            public bool Open
            {
                get { return State.Open; }
                set
                {
                    State.Open = value;
                    OnStateChanged?.Invoke();
                }
            }

            public Manager(MwcDrawerState state)
            {
                State = state;
            }
        }
    }
}