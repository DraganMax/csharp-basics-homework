using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        private string _sex;
        private string _name;
        private string _mother;
        private string _father;

        public Dog(string name, string sex, string mother, string father)
        {
            _sex = sex;
            _name = name;
            _mother = mother;
            _father = father;
        }
        public Dog(string name, string sex)
        {
            _sex = sex;
            _name = name;
        }

        public string FathersName()
        {
            if (_father == null)
            {
                _father = "Unknown";
            }
            return _father;
        }
        public bool HasSameMotherAs(Dog otherDog)
        {
            if (_mother != null && _mother == otherDog._mother)
            {
                return true;
            }
            return false;
        }
    }
}
