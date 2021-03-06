﻿using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver;
using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands
{
    class CeilingFanHighCommand : ICommand
    {
        readonly CeilingFan _ceilingFan;
        CeilingFan.CeilingFanSpeed _prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.SetHighSpeed();
        }

        public void Undo()
        {
            switch (_prevSpeed)
            {
                case CeilingFan.CeilingFanSpeed.High:
                    _ceilingFan.SetHighSpeed();
                    break;
                case CeilingFan.CeilingFanSpeed.Medium:
                    _ceilingFan.SetMediumSpeed();
                    break;
                case CeilingFan.CeilingFanSpeed.Low:
                    _ceilingFan.SetLowSpeed();
                    break;
                default:
                    _ceilingFan.SetOff();
                    break;
            }
        }
    }
}
