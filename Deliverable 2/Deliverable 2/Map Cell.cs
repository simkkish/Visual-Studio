using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2
{
    class Map_Cell
    {
        #region Variable
        private bool _HasMonster;
        private bool _HasItem;
        private bool _IsDiscovered;
        #endregion

        /// <summary>
        /// getter and setter
        /// </summary>
        #region Constructor
        public bool HasMonster
        {
            get
            {
                return _HasMonster;
            }
            set
            {
                _HasMonster = value;
            }
        }
        public bool HasItem
        {
            get
            {
                return _HasItem;
            }
            set
            {
                _HasItem = value;
            }

        }
        public bool IsDiscovered
        {
            get
            {
                return _IsDiscovered;
            }
            set
            {
                _IsDiscovered = value;
            }
        }
        #endregion
        #region Method
        public Map_Cell(bool monster, bool item, bool discovered)
        {
            _HasMonster = monster;
            _HasItem = item;
            _IsDiscovered = discovered;
        }
        public void Discovered(bool val)
        {
            _IsDiscovered = val;
        }
        #endregion
    }
}
