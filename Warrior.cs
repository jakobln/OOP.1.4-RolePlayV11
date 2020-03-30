namespace RolePlayV11
{
    public class Warrior
    {
        #region Instance fields
        private string _name;
        private int _level;
        private int _hitpoints;
        #endregion

        #region Constructor
        public Warrior(string name, int hitpoints)
        {
            _name = name;
            _level = 1;
            _hitpoints = hitpoints;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int Level
        {
            get { return _level; }
        }

        public int Hitpoints
        {
            get { return _hitpoints; }
        }

        public bool Dead
        {
            get { return (_hitpoints <= 0);}
        }
        #endregion

        #region Methods
        public void LevelUp()
        {
            _level = _level + 1;
        }

        public void DamageTaken(int deltahitpoints)
        {
            _hitpoints = _hitpoints - deltahitpoints;
        }
        #endregion
    }
}