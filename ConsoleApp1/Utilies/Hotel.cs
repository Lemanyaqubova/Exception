using ConsoleApp1.Utilies.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Utilies
{
    class Hotel
    {
        public Hotel(string name, int length)
        {
            Name = name;
            _rooms = new Room[length];
        }

        private Room[] _rooms;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Room this[int index]
        {
            get
            {
                if (index < _rooms.Length)
                {
                    return _rooms[index];
                }
                else
                    throw new NotFoundException("Not found");
            }
            set
            {
                if (index < _rooms.Length)
                {
                    _rooms[index] = value;
                }
                else
                    throw new NotAvailableException("Not avaible");
            }

        }
    }

}