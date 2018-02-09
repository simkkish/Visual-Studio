using System;
namespace Deliverable_2
{
    class Actor
    {
        #region Variable
        /// <summary>
        /// Initializing the Variable that are private to actor class
        /// </summary>
        private string _Name;
        private string _Title;
        private int _MaxHP;
        private int _PositionX;
        private int _PositionY;
        private int _AttackSpeed;
        private int _CurrentHP;
        #endregion
        #region Constructor
        /// <summary>
        /// Getter and setter
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }

        public int MaxHP
        {
            get
            {
                return _MaxHP;
            }

        }
        public int PositionX
        {
            get
            {
                return _PositionX;
            }
        }
        public int PositionY
        {
            get
            {
                return _PositionY;
            }
        }
        public int AttackSpeed
        {
            get
            {
                return _AttackSpeed;
            }
            set
            {
                _AttackSpeed = value;
            }
        }
        public int CurrentHP
        {
            get
            {
                return _CurrentHP;
            }

        }
        #endregion
        #region Over Loadded Constructor
        public Actor(string name, string title, int hp, int attackSpeed, int positionX, int PositionY)
        {
            _Name = name;
            _Title = title;
            _MaxHP = hp;
            _CurrentHP = hp;
            _PositionX = positionX;
            _PositionY = PositionY;
        }
        #endregion
        #region Method
        public void Damage(int damage)
        {
            int CurrentHp = _CurrentHP;
            if ((CurrentHp - damage) >= 0)
            {
                CurrentHp -= damage;
            }
            else
            {
                CurrentHp = 0;
            }
            _CurrentHP = CurrentHp;
        }
        public void Heal(int heal)
        {
            int CurrentHp = _CurrentHP;
            if ((CurrentHp + 5) <= _MaxHP)
            {
                CurrentHp = (_CurrentHP + 5);
            }
            else
            {
                CurrentHp = _MaxHP;
            }
            _CurrentHP = CurrentHp;
        }
        public void Move(direction d)
        {

            if (d == direction.Left)
            {
                _PositionX -= 1;
            }
            else if (d == direction.Right)
            {
                _PositionX += 1;
            }
            else if (d == direction.down)
            {
                _PositionY -= 1;
            }
            else if (d == direction.Up)
            {
                _PositionY += 1;
            }
        }
        public string Capatalized(string name)
        {
            if (name != "" & name != null)
            {
                //while (name.Trim() != "")
                //{
                _Name = name.ToUpper()[0] + name.Substring(1);

                //  }

                //Cap = Cap[0] + Cap.Substring(1, Cap.Length);
                //_Name = Cap;
            }
            return _Name;
        }


        /// <summary>
        /// Converting title case I found this in the below site :(
        /// </summary>
        /// <param name="title"> input form user</param>
        /// <returns></returns>
        /// https://stackoverflow.com/questions/1206019/converting-string-to-title-case
        public string TitleCase(string title)
        {
            Char firstChar = ' ';
            String rest = "";
            if (title != null)
            {
                String[] words = title.Split(' ');
                String[] check = new string[] { "" };
                for (int i = 0; i < words.Length; i++)
                {
                    // if (words[1];
                    if (words[i].Length != 0)
                    {
                        firstChar = Char.ToUpper(words[i][0]);
                        if (words[i].Length > 1)
                        {
                            rest = words[i].Substring(1).ToLower();
                        }
                        // _Title += firstChar + rest + " ";
                    }
                    _Title += firstChar + rest;
                }

            }

            return _Title;
        }
        #endregion
        #region Enum
        public enum direction
        {
            Left,
            Right,
            Up,
            down
        }
        #endregion

    }
}
