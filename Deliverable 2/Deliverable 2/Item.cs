namespace Deliverable_2
{
    class Item
    {
        private string _ItemName;
        private int _Value;
        #region Constructor
        public string ItemName
        {
            get
            {
                return _ItemName;
            }
            set
            {
                _ItemName = value;
            }
        }
        public int Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }
        #endregion

        /// <summary>
        /// Over Loaded constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="value"></param>
        public Item(string Name, int value)
        {
            _ItemName = Name;
            _Value = value;
        }

    }
}

