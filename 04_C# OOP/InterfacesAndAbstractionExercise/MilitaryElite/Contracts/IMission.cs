﻿using MilitaryElite.Contracts.Enums;

namespace MilitaryElite.Contracts
{
    public interface IMission
    {
        public string CodeName { get; }
        public State State { get; }
        public void CompleateMissio();
    }
}